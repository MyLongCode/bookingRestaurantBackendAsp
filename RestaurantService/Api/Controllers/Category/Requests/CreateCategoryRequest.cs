﻿using System.ComponentModel.DataAnnotations;

namespace Api.Controllers.Category.Requests
{
    public record CreateCategoryRequest
    {
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public int MenuId { get; set; }
    }
}
