using Dal.EF;
using Dal.User.Models;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Api.Controllers
{
    [Route("/user")]
    public class UserController : Controller
    {
        ApplicationDbContext db;

        public UserController(ApplicationDbContext db) => this.db = db;

        public IActionResult Index()
        {
            return Ok("пацаны бэк 500 вернул");
        }
        [HttpPost]
        public IActionResult Login(UserDal userData)
        {
            UserDal? person = db.Users.FirstOrDefault(p => p.Email == userData.Email && p.Password == userData.Password);
            // если пользователь не найден, отправляем статусный код 401
            if (person is null) return Ok("user is not defined");

            var claims = new List<Claim> { new Claim(ClaimTypes.Name, person.Email) };
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: "mylongcode",
                    audience: "dotnetclient",
                    claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8
                              .GetBytes("mylongcode")), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            // формируем ответ
            var response = new
            {
                access_token = encodedJwt,
                username = person.Email
            };

            return Json(response);
        }

    }
}
