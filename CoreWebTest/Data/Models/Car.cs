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
        public string ShortDesc { set; get; } // крадкое описание
        public string LongDesc { set; get; } // большое описание
        public string Img { set; get; } // картинка
        public ushort price { set; get; }
        public bool IsFavourite { set; get; } // отображение на главнойй странице
        public int available { set; get; } // товар на складе. Сколько в запасе
        public ushort CategoryID { set; get; } //ID категорииы
        /// <summary>
        /// Свойство хранит категории товаров. Пока есть 2 категории
        /// </summary>
        public virtual Category Category { set; get; } // Свойство хранит категории товаров 

        //У каждого товара нужна только 1 категория
    }

}
