using CoreWebTest.Data.interfaces;
using CoreWebTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebTest.Data.Mocks
{
    /// <summary>
    /// Реализует интерфейс IAllCars
    /// </summary>
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();

        //получение все товаров
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> //Возращаем лист с обьектом кар
                {
                    new Car
                    {
                        Name ="Tesla",
                        ShortDesc ="Быстрий, экологический автомобиль",
                        LongDesc ="Красивый, быстрый, высокотехнологичный, и очень тихий автомобиль",
                        Img ="https://avatars.mds.yandex.net/get-pdb/70729/63087494-d9d2-455c-ad64-5e9c1a7664a2/s1200?webp=false",
                        price =45000,
                        IsFavourite =true,
                        available =true,
                        Category = _carsCategory.AllCategories.First()
                },
                new Car
                {
                    Name = "Ford Fiesta",
                    ShortDesc = "Небольшой автомобиль для города",
                    LongDesc = "Субкомпактный автомобиль, выпускаемый компанией Ford Motor Company. ",
                    Img = "https://st.motortrend.com/uploads/sites/5/2017/06/2018-Ford-Fiesta-Titanium-Euro-Spec-front-three-quarter-in-motion-02.jpg",
                    price = 11000,
                    IsFavourite = true,
                    available = true,
                    Category = _carsCategory.AllCategories.Last()
                },
                 new Car
                {
                    Name = "BMW M3",
                    ShortDesc = "Высокотехнологичная спортивная версия компактных автомобилей BMW 3 серии от BMW M GmbH.",
                    LongDesc = "Модели M3 сделаны на базе E30, E36, E46, E90/E92/E93 и F30 3-ей серии. Основные отличия от «стандартных» автомобилей 3 серии включают более мощный двигатель, улучшенную подвеску, более агрессивный и аэродинамичный обвес, множественные акценты как в интерьере так и в экстерьере на принадлежность к линейке «M»/Motorsport.",
                    Img = "https://www.netcarshow.com/BMW-M3_Sedan-2015-1600-08.jpg",
                    price = 65000,
                    IsFavourite = true,
                    available = true,
                    Category = _carsCategory.AllCategories.Last()
                },

                 new Car
                {
                    Name = "Mercedes-Benz C-класс",
                    ShortDesc = "Серия компактных представительских автомобилей немецкой автомобилестроительной компании Mercedes-Benz, дебютировавшая в 1993 году. ",
                    LongDesc = " A-класса в 1997 году серия представляла собой самые малые автомобили как по габаритам, так и по классификации в иерархии марки Mercedes-Benz. C-класс включает в себя четыре поколения: W202, представленный в 1992 году, W203, сошедший с конвейера 18 июля 2000 года, W204, выпускавшегося с 2007 года и W205, дебютировавшего в 2014 году и производящегося до настоящего времени.",
                    Img = "https://s1.1zoom.ru/big7/701/Mercedes-Benz_White_437294.jpg",
                    price = 40000,
                    IsFavourite = true,
                    available = true,
                    Category = _carsCategory.AllCategories.Last()
                },
                 new Car
                {
                    Name = "Nissan Leaf",
                    ShortDesc = "Электромобиль японского концерна Nissan, серийно выпускаемый с весны 2010 года. ",
                    LongDesc = "Электромобиль японского концерна Nissan, серийно выпускаемый с весны 2010 года. Мировая премьера состоялась на международном Токийском автосалоне в 2009 году. Заказы на модель японские и американские дилеры компании начали принимать 1 апреля 2010 года",
                    Img = "https://www.avtorinok.ru/photo/Nissan_Leaf_pic_103946.jpg",
                    price = 14000,
                    IsFavourite = true,
                    available = true,
                    Category = _carsCategory.AllCategories.First()
                }
                };

            }
        }

        ///Получение избранных товаров
        public IEnumerable<Car> GeFavtCars { get; set; }

        ///Получение  товаров по id
        public Car GetObectCar(int catId)
        {
            throw new NotImplementedException();
        }



    }
}
