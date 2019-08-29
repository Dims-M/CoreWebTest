using CoreWebTest.Data.interfaces;
using CoreWebTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        /// <summary>
        /// Переменная для связи с контекстом БД
        /// </summary>
        private readonly AppDBContent appDBContext;

        /// <summary>
        ///Конструктор. При созании любого класса CategoryRepository будет создоватся контент для связи с таблиценй Категории
        /// </summary>
        /// <param name="appDBContext"></param>
        public CategoryRepository(AppDBContent appDBContext)
        {
            this.appDBContext = appDBContext; // указываем на связ с категорией.
        }

        IEnumerable<Category> ICarsCategory.AllCategories => throw new NotImplementedException();

        /// <summary>
        /// Получение всех категорий для товаров. Пока их 2
        /// </summary>
        public IEnumerable<Category> AllCategories => appDBContext.Category;

    }
}
