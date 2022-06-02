using AspNetApp.Models;

namespace AspNetApp
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AttachRange(

                    new Car
                    {
                        name = "КАРТОФЕЛЬ",
                        shortDesc = "Свежий и полезный",
                        longDesc = "Вкусно и полезно",
                        img = "/img/1.jpg",
                        price = 300,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "АПЕЛЬСИНЫ",
                        shortDesc = "Много витамин",
                        longDesc = "Для здоровья",
                        img = "/img/4.jpg",
                        price = 500,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Класические автомобильи"]
                    },
                    new Car
                    {
                        name = "ЯБЛОКИ",
                        shortDesc = "Много витамин",
                        longDesc = "Для здоровья",
                        img = "/img/5.jpg",
                        price = 350,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Класические автомобильи"]
                    },
                    new Car
                    {
                        name = "БАНАНЫ",
                        shortDesc = "Много витамин",
                        longDesc = "Для здоровья",
                        img = "/img/6.jpeg",
                        price = 400,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Класические автомобильи"]
                    },
                    new Car
                    {
                        name = "КАПУСТА",
                        shortDesc = "Свежий и полезный",
                        longDesc = "Вкусно и полезно",
                        img = "/img/2.jpg",
                        price = 500,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "МОРКОВЬ",
                        shortDesc = "Свежий и полезный",
                        longDesc = "Вкусно и полезно",
                        img = "/img/3.jpg",
                        price = 200,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Электромобили"]
                    }

                    );
            }

            content.SaveChanges();

        }



        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                         new Category{categoryName = "Электромобили", desc = "Современный вид транспорта"},
                         new Category {categoryName = "Класические автомобильи", desc = "Машины с двигателем внутреньнего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
