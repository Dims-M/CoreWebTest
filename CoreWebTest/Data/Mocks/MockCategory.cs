using CoreWebTest.Data.interfaces;
using CoreWebTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data.Mocks
{
    /// <summary>
    /// Класс реализует интерфейс ICarsCategory 
    /// </summary>
    public class MockCategory : ICarsCategory
    {
        // реализуем интервейс
        public IEnumerable<Category> AllCategories { 
            get {return new List<Category>{ // возращаем новый лист с категориями
            new Category{CategoryName ="Электромобили",desc ="Современнные высокотехнологичный вид транспорта" },
            new Category{CategoryName ="Классичискте автомобили",desc ="Машины с двигателем внутреннего сгорания" },
            new Category{CategoryName ="Дизель автомобили",desc ="Машины с дизельным двигателем внутреннего сгорания" }
       };
};
        }
    }
}
