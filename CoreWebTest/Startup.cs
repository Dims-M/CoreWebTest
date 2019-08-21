using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebTest.Data.interfaces;
using CoreWebTest.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CoreWebTest
{
    public class Startup
    {
        //Этот метод вызывается средой выполнения. Этот метод используется для добавления служб в контейнер.
        // Дополнительные сведения о настройке приложения см. На странице https://go.microsoft.com/fwlink/?LinkID=398940
        // для регистрации дополнительных модулей
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllCars, MockCars>(); // Позволяет обьединить интерфейс и класс реализовывабщий этот интерфейс // Добавляет временную службу типа, указанного в поле Тип службы с фабрикой
            services.AddTransient<ICarsCategory, MockCategory>();
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
