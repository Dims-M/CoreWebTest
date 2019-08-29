using CoreWebTest.Data.interfaces;
using CoreWebTest.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data.Repository
{
    public class CarRepository : IAllCars
    {
        /// <summary>
        /// Переменная для связи с контекстом БД
        /// </summary>
        private readonly AppDBContent appDBContext; 

        /// <summary>
        /// Для связи с таблиценй Категории
        /// </summary>
        /// <param name="appDBContext"></param>
        public CarRepository(AppDBContent appDBContext)
        {
            this.appDBContext = appDBContext; // указываем на связ с категорией.
        }
            
        /// <summary>
        ///Свойство Получает все категории из БД САR
        /// </summary>
        public IEnumerable<Car> Cars => appDBContext.Car.Include(c => c.Category);

        /// <summary>
        ///Свойство Получает все товары с главной страници с атрибутом фаворит из БД САR
        /// </summary>
        public IEnumerable<Car> GeFavtCars => appDBContext.Car.Where(c => c.IsFavourite); //

        /// <summary>
        ///Свойство Получает по ID товары из БД САR
        /// </summary>
        public Car GetObectCar(int catId)
        {
           var GetIdCar = appDBContext.Car.Where(c => c.Id == catId);
            return (Car)GetIdCar; // TODO ?????????????????????????????Ы  НЕ факт что будет работать
        }
    }
}
