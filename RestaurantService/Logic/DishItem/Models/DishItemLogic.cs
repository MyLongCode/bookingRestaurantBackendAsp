﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DishItem.Models
{
    internal class DishItemLogic
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public string Compound { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }
    }
}
