using CoreWebTest.Data.interfaces;
using CoreWebTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data.Mocks
{
    /// <summary>
    /// Реализует интерфейс IAllCars
    /// </summary>
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();

        //получение все товаров
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> //Возращаем лист с обьектом кар
                {
                    new Car{Name ="Tesla",ShortDesc="",LongDesc="",Img="",price=45000,IsFavourite=true,available=true, Category = _carsCategory.AllCategories.First()}
                };

            }
        }

        ///Получение избранных товаров
        public IEnumerable<Car> GeFavtCars { get; set; }

        ///Получение  товаров по id
        public Car GetObectCar(int catId)
        {
            throw new NotImplementedException();
        }
    }
}
