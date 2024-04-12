using Dal.Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Category.Models
{
    public class CategoryDal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public int MenuId { get; set; }
        public MenuDal Menu{ get; set; }
    }
}
