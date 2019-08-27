using CoreWebTest.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data
{
    /// <summary>
    /// Класс для связи между программой и базой данных 
    /// </summary>
    public class AppDBContent : DbContext
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        /// <summary>
        /// Свойство Саr для связи с БД
        /// </summary>
        public DbSet<Car> Car{get; set;}
        /// <summary>
        /// Свойство Category для связи с БД
        /// </summary>
        public DbSet<Category> Category { get; set; }


    }
}
