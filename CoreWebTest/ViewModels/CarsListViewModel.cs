using CoreWebTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.ViewModels
{
    /// <summary>
    /// класс описывает общую модель
    /// </summary>
    public class CarsListViewModel
    {
        /// <summary>
    /// Свойство для получеия всех товаров
    /// </summary>
        public IEnumerable<Car> AllCars { get; set; }


        /// <summary>
        /// Свойство для работы с категорией
        /// </summary
        public string CurrentCategory { get; set; }
    }
}
