using CoreWebTest.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data
{
    /// <summary>
    /// Класс для 
    /// </summary>
    public class DBObjects
    {
        //IApplicationBuilder запуск метода их класса страртап. И эти методы будут активны при старте программы
        /// <summary>
        /// Метод Initial инизиализует пустую базу данных
        /// </summary>
        /// <param name="app"></param>
        public static void Initial(IApplicationBuilder app)  
        {
            AppDBContent content;
            using (var scope = app.ApplicationServices.CreateScope()) // метод CreateScope создаем область видимости сервиса
            {
                content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            }

            ///Связь с БД через  AppDBContent content
          //  AppDBContent content = app.ApplicationServices.GetRequiredService<AppDBContent>();

            ///Проверяем. Если категория пустая. То будет тру. И будет автозаполнение БД первоночальными данными
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c =>c.Value)); // добовляем набор элементов
            }

            //проверяем. Если товаров в БД нет. То их создаем
            if (!content.Car.Any())
            {
                //добавляем товары. Бывает при первом запуске
                content.AddRange
                    (

                    new Car
                    {
                        Name = "Tesla",
                        ShortDesc = "Быстрий, экологический автомобиль",
                        LongDesc = "Красивый, быстрый, высокотехнологичный, и очень тихий автомобиль",
                        // Img ="https://avatars.mds.yandex.net/get-pdb/70729/63087494-d9d2-455c-ad64-5e9c1a7664a2/s1200?webp=false",
                        Img = "/img/tesla.jpg",
                        price = 45000,
                        IsFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                new Car
                {
                    Name = "Ford Fiesta",
                    ShortDesc = "Небольшой автомобиль для города",
                    LongDesc = "Субкомпактный автомобиль, выпускаемый компанией Ford Motor Company. ",
                    //Img = "https://st.motortrend.com/uploads/sites/5/2017/06/2018-Ford-Fiesta-Titanium-Euro-Spec-front-three-quarter-in-motion-02.jpg",
                    Img = "/img/fiesta.jpg",
                    price = 11000,
                    IsFavourite = true,
                    available = true,
                    Category = Categories["Дизель автомобили"]
                },
                 new Car
                 {
                     Name = "BMW M3",
                     ShortDesc = "Высокотехнологичная спортивная версия компактных автомобилей BMW 3 серии от BMW M GmbH.",
                     LongDesc = "Модели M3 сделаны на базе E30, E36, E46, E90/E92/E93 и F30 3-ей серии. Основные отличия от «стандартных» автомобилей 3 серии включают более мощный двигатель, улучшенную подвеску, более агрессивный и аэродинамичный обвес, множественные акценты как в интерьере так и в экстерьере на принадлежность к линейке «M»/Motorsport.",
                     //Img = "https://www.netcarshow.com/BMW-M3_Sedan-2015-1600-08.jpg",
                     Img = "/img/BMW-M3_Sedan.jpg",
                     price = 65000,
                     IsFavourite = true,
                     available = true,
                     Category = Categories["Классические автомобили"]
                 },

                 new Car
                 {
                     Name = "Mercedes-Benz C-класс",
                     ShortDesc = "Серия компактных представительских автомобилей немецкой автомобилестроительной компании Mercedes-Benz, дебютировавшая в 1993 году. ",
                     LongDesc = " A-класса в 1997 году серия представляла собой самые малые автомобили как по габаритам, так и по классификации в иерархии марки Mercedes-Benz. C-класс включает в себя четыре поколения: W202, представленный в 1992 году, W203, сошедший с конвейера 18 июля 2000 года, W204, выпускавшегося с 2007 года и W205, дебютировавшего в 2014 году и производящегося до настоящего времени.",
                     // Img = "https://s1.1zoom.ru/big7/701/Mercedes-Benz_White_437294.jpg",
                     Img = "/img/Mercedes.jpg",
                     price = 40000,
                     IsFavourite = false,
                     available = false,
                     Category = Categories["Классические автомобили"]
                 },
                 new Car
                 {
                     Name = "Nissan Leaf",
                     ShortDesc = "Электромобиль японского концерна Nissan, серийно выпускаемый с весны 2010 года. ",
                     LongDesc = "Электромобиль японского концерна Nissan, серийно выпускаемый с весны 2010 года. Мировая премьера состоялась на международном Токийском автосалоне в 2009 году. Заказы на модель японские и американские дилеры компании начали принимать 1 апреля 2010 года",
                     // Img = "https://www.avtorinok.ru/photo/Nissan_Leaf_pic_103946.jpg",
                     Img = "/img/Nissan_Leaf.jpg",
                     price = 14000,
                     IsFavourite = false,
                     available = true,
                     Category = Categories["Электромобили"]
                 }


                    );
            }


        }

        private static Dictionary<string, Category> category;
        /// <summary>
        /// Метод для создания и возврата справочника категорий. Для метода Initial
        /// </summary>
        public static Dictionary<string, Category> Categories
        {

            get
            {
                if (category == null) //Если переменная справочника пустая category. Создаем стандартные категории
                {
                    var list = new Category[]
                    {
                new Category { CategoryName = "Электромобили", desc = "Современнные высокотехнологичный вид транспорта" },
                new Category { CategoryName = "Классичискте автомобили", desc = "Машины с двигателем внутреннего сгорания" },
                new Category { CategoryName = "Дизель автомобили", desc = "Машины с дизельным двигателем внутреннего сгорания" }
                    };
                    category = new Dictionary<string, Category>();

                    foreach (Category el in list )
                    {
                        category.Add(el.CategoryName, el); // добавляем в справочник. Имя категории как ключ, сам обьект как значение 
                    }
                }
                return category; // возврат категории с описанием товаров
            }

            
        }



    }
}
