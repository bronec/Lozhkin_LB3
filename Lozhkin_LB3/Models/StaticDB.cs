using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lozhkin_LB3.Models
{
    public static class StaticDB
    {
        public static List<ProductModel> Products { get; set; } = new List<ProductModel>()
        {
            new ProductModel()
            {
                Id = 1,
                Description = "Мяско коровы",
                Name = "Мясо",
                Price = "200 RUB"
            },
                new ProductModel()
            {
                Id = 2,
                Description = "Мяско курицы",
                Name = "Курица",
                Price = "13 RUB"
            },
                new ProductModel()
            {
                Id = 3,
                Description = "Мяско рыбы",
                Name = "Рыбы",
                Price = "45 RUB"
            },
                new ProductModel()
            {
                Id = 4,
                Description = "Пиво Лидское",
                Name = "Вода",
                Price = "35 RUB"
            },
                new ProductModel()
            {
                Id = 5,
                Description = "Мяско Барана",
                Name = "Мясо",
                Price = "95 RUB"
            },
                new ProductModel()
            {
                Id = 6,
                Description = "Вода Бонаква",
                Name = "Вода",
                Price = "25 RUB"
            }
        };
    }
}
