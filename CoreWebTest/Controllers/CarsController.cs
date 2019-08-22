using CoreWebTest.Data.interfaces;
using CoreWebTest.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Controllers
{
    /// <summary>
    /// Класс контроллера. отвечает за все товары
    /// </summary>
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;
       
        //конструктор
      public  CarsController(IAllCars iAllCars, ICarsCategory iCarsCat) // передаем 2 обьекта интерфейса. иза связки интерфейса и класса который его реализует.  то мы можем работать с этим классом
        {
            _allCars = iAllCars; //нужные обьекты 
            _carsCategory = iCarsCat;
        }

        public ViewResult List()
        {
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars; // получение всех автомоблей
            obj.CurrentCategory = "Автомобили"; // категории товара

           // ViewBag.Category = "*******";
           //  var cars = _allCars.Cars; // получаем все машины из моделеей через интерфейс
            return View(obj); //Возврат вьюха
        }
    }
}
