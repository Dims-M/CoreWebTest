using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data.Models
{
    /// <summary>
    /// Класс описывающий товары
    /// </summary>
    public class Car
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string ShortDesc { set; get; }
        public string LognDesc { set; get; }
        public string Img { set; get; }
        public ushort price { set; get; }
        public bool IsFavourite { set; get; }
        public int available { set; get; }
        public ushort CategoryID { set; get; }
        public virtual Category Category { set; get; } // Свойство хранит категории товаров
    }
}
