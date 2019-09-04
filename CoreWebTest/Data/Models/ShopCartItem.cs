using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data.Models
{
    /// <summary>
    /// Класс описывает корзину покупок
    /// </summary>
    public class ShopCartItem
    {
        
        public int Id { set; get; } // получение ID товара

        public Car Сar { get; set; } // Само свойство для получения товара и добавление его в корзину покупки

        public int Praicу { get; set; } //Получение цены товара

        public string ShopCartId { get; set; }
    }
}
