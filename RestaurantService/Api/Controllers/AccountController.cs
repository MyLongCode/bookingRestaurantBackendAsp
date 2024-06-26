﻿using Api.Controllers.User.Requests;
using Api.Models;
using Logic.User.Interfaces;
using Logic.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Api.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserLogicManager _userLogicManager;

        public AccountController(IUserLogicManager userLogicManager)
        {
            _userLogicManager = userLogicManager;
        }

        [HttpPost("/token")]
        public IActionResult Token(GetUserTokenRequest dto)
        {
            var identity = GetIdentity(dto.Username, dto.Username);
            if (identity == null)
            {
                return BadRequest(new { errorText = "Invalid username or password." });
            }

            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
            issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
            notBefore: now,
            claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                access_token = encodedJwt,
                username = identity.Name
            };
            return Ok(response);
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult RegisterUser(UserRegisterRequest dto)
        {
            var userId = _userLogicManager.CreateUser(new UserLogic
            {
                Email = dto.Email,
                Password = dto.Password,
                FullName = dto.FullName,
                BirthDate = dto.BirthDate,
                PhoneNumber = dto.PhoneNumber,
                Avatar = dto.Avatar,
                RoleId = 1
            }).Result;
            if (userId == -1) return BadRequest("User is not registration");
            return Ok(userId);
        }

        private ClaimsIdentity GetIdentity(string username, string password)
        {
            if (_userLogicManager.CheckUserPassword(username, password).Result != false)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, username),
                    //new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role)
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            // если пользователя не найдено
            return null;
        }
    }
}
