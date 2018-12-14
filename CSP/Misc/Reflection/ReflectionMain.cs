using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Reflection
{
    public class ReflectionMain
    {
        public static void Run()
        {
            var newBrand = new Water
            {
                Price = 4,
                Size = "Large",
                Brands = new List<Brand>
                {
                    new Brand
                    {
                        Popularity = "Very"
                    }
                }
            };

            Console.WriteLine(string.Join("&", newBrand.GetType().GetProperties().Where(s => s.GetValue(newBrand, null) != null && !s.PropertyType.IsGenericType).Select(s => string.Format($"{s.Name}={s.GetValue(newBrand)}"))));
            Console.WriteLine(string.Join("&", newBrand.Brands.Select(s => s).GetType().GetProperties().Where(s => s.GetValue(newBrand.Brands.First(), null) != null).Select((s) => string.Format($"{s.Name}={s.GetValue(newBrand.Brands)}"))));
        }

        public class Water
        {
            public int Price { get; set; }

            public string Size { get; set; }

            public List<Brand> Brands { get; set; }
        }

        public class Brand
        {
            public string ParentCompany { get; set; }

            public string Popularity { get; set; }
        }
    }
}
