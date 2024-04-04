using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Base
{
    public record BaseEntityDal<T>
    {
        /// <summary>
        /// уникальный идентфиикатор сущности
        /// </summary>
        public T Id { get; set; }
    }
}
