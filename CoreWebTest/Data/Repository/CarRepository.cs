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
        /// Получаем все категории из БД САR
        /// </summary>
        public IEnumerable<Car> Cars => appDBContext.Car.Include(c => c.Category);

        public IEnumerable<Car> GeFavtCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car GetObectCar(int catId)
        {
            throw new NotImplementedException();
        }
    }
}
