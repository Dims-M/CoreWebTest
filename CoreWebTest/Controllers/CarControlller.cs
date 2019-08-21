using CoreWebTest.Data.interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Controllers
{
    /// <summary>
    /// Класс контроллера
    /// </summary>
    public class CarControlller : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;
       
        //конструктор
      public  CarControlller(IAllCars iAllCars, ICarsCategory iCarsCat) // передаем 2 обьекта интерфейса. иза связки интерфейса и класса который его реализует.  то мы можем работать с этим классом
        {
            _allCars = iAllCars;
            _carsCategory = iCarsCat;
        }

        public ViewResult List()
        {
            return View(); //Возврат вьюха
        }
    }
}
