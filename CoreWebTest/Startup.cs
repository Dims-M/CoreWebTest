using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebTest.Data;
using CoreWebTest.Data.interfaces;
using CoreWebTest.Data.Mocks;
using CoreWebTest.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreWebTest
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        //конструктор
       public Startup(IHostingEnvironment hostEnv)
        {
            //При создании любого обьекта. Будет создаватся строка подключения к БД. С помощью этого метода
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }


        //Этот метод вызывается средой выполнения. Этот метод используется для добавления служб в контейнер.
        // Дополнительные сведения о настройке приложения см. На странице https://go.microsoft.com/fwlink/?LinkID=398940
        // для регистрации дополнительных модулей
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection"))); // дбавляем загрузку строки с настройками sql базы
           // services.AddTransient<IAllCars, MockCars>(); // Позволяет обьединить интерфейс и класс реализовывабщий этот интерфейс // Добавляет временную службу типа, указанного в поле Тип службы с фабрикой
            services.AddTransient<IAllCars, CarRepository>(); // Позволяет обьединить интерфейс и класс реализовывабщий этот интерфейс // Добавляет временную службу типа, указанного в поле Тип службы с фабрикой
          //  services.AddTransient<ICarsCategory, MockCategory>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
            services.AddMvc(); // gподключаем модуль мвс
        }

        //Этот метод вызывается средой выполнения. Этот метод используется для настройки конвейера HTTP-запросов.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage(); //отображаем страцицы с ошибками
            app.UseStatusCodePages(); // оображаем статусы страничек //400, 500, 200
            app.UseStaticFiles(); // отображаем статические файлы 
            app.UseMvcWithDefaultRoute();  // включение мвс патерна  отслеживание урл адреса. и вьюхи к этим адресам

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
