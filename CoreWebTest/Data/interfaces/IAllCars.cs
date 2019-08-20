using CoreWebTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data.interfaces
{
    /// <summary>
    /// Интерфейсдля работы стоварами
    /// </summary>
    interface IAllCars
    {
        // тим перечесление  IEnumerable перечислитель, который поддерживает простой перебор элементов неуниверсальной коллекции.
        //Получаем все товары
        IEnumerable<Car> Cars { get; set; }
      
        //Получаем избранный товар. Тот товар который будет показан на главной странице
        IEnumerable<Car> GeFavtCars { get; set; }

        //получаем рдин товар по ID
        Car GetObectCar(int catId); // 


    }
}
