using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data.Models
{
    /// <summary>
    /// Класс отвкчающий за категории на сайте
    /// </summary>
    public class Category
    {
        public int Id { set; get; }
        public string CategoryName { set; get; }
        public string desc { set; get; } // описание 
        public List <Car>  Cars{ set; get; } // лист для хранения товаров
    }
}
