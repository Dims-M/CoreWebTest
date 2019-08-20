using CoreWebTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data.interfaces
{
    interface ICarsCategory
    {
        /// <summary>
        /// Интерфейс для получения данных из категорий
        /// </summary>
        IEnumerable<Category> AllCategories {get; }
    }
}
