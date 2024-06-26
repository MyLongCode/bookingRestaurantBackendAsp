﻿using Dal.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Photo.Models
{
    public class PhotoDal
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public int RestaurantId { get; set; }
        public RestaurantDal Restaurant { get; set; }
    }
}
