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
        public IEnumerable<Car> GeFavtCars => appDBContext.Car.Where(c => c.IsFavourite).Include(c=>c.Category); // ПОЛУЧАЕМ все категории товаров  IsFavourite с атрибутом тру и выводим с списком с категориями

        /// <summary>
        ///Свойство Позволяет добавить данные в БД. Пока не работает.
        /// </summary>
        IEnumerable<Car> IAllCars.GeFavtCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        ///Свойство Получает по ID товары из БД САR
        /// </summary>
        //public Car GetObectCar(int catId)
        //{
        //   var GetIdCar = appDBContext.Car.Where(c => c.Id == catId);
        //    return (Car)GetIdCar; // TODO ?????????????????????????????Ы  НЕ факт что будет работать
        //}

       
        public Car GetObectCar(int catId) => appDBContext.Car.FirstOrDefault(item => item.Id == catId); //получаем первое нужное совпадение при поиске по ip
        //Аналогичный метод


    }
}
