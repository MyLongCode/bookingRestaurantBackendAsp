using Api.Controllers.Category.Requests;
using Dal.EF;
using Logic.Category.Interfaces;
using Logic.Category.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace Api.Controllers
{
    [Route("/category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryLogicManager _categoryLogicManager;
        IWebHostEnvironment _appEnvironment;

        public CategoryController(ICategoryLogicManager categoryLogicManager, IWebHostEnvironment appEnvironment)
        {
            _categoryLogicManager = categoryLogicManager;
            _appEnvironment = appEnvironment;
        }


        /// <summary>
        /// Создать новую категорию
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/category")]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequest dto)
        {
            string path = "";
            IFormFile image = dto.Photo;
            SaveImage(image);

            await _categoryLogicManager.CreateCategory(new CategoryLogic
            {
                Name = dto.Name,
                Photo = image.FileName,
                MenuId = dto.MenuId,

            });
            return Ok("пацаны бэк 500 вернул");
        }
        private async void SaveImage(IFormFile image)
        {
            if (image != null)
            {
                // путь к папке Files
                string path = image.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + "/Files/" + path, FileMode.Create))
                {
                    await image.CopyToAsync(fileStream);
                }

            }
        }

    }
}
