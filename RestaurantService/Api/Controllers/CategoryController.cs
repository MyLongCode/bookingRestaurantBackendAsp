using Api.Controllers.Category.Requests;
using Logic.Category.Interfaces;
using Logic.Category.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("/category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryLogicManager _categoryLogicManager;

        public CategoryController(ICategoryLogicManager categoryLogicManager)
        {
            _categoryLogicManager = categoryLogicManager;
        }

        [HttpPost]
        [Route("/category")]
        public IActionResult CreateCategory(CreateCategoryRequest dto)
        {
            _categoryLogicManager.CreateCategory(new CategoryLogic
            {
                Name = dto.Name,
                Photo = dto.Photo,
                MenuId = dto.MenuId,
                
            });
            return Ok("пацаны бэк 500 вернул");
        }
    }
}
