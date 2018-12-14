using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSP.SOLID
{
    public class OpenClosedPrincipleTest
    {
        public static void Run()
        {
            var products = new List<Product>
            {
                new Product("Apple", Color.Green, Size.Small),
                new Product("Carrot", Color.Red, Size.Small),
                new Product("Blueberry", Color.Blue, Size.Small)
            };

            var bf = new BetterFilter();
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Red)))
            {
                Console.WriteLine($" - {p.Name} is red");
            }
        }

        public enum Color
        {
            Red,
            Green,
            Blue
        }

        public enum Size
        {
            Small,
            Medium,
            Large
        }

        public class Product
        {
            public string Name { get; set; }

            public Color Color { get; set; }

            public Size Size { get; set; }

            public Product(string name, Color color, Size size)
            {
                this.Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
                this.Color = color;
                this.Size = size;
            }
        }

        public interface ISpecification<in T>
        {
            bool IsSatisfied(T t);
        }

        public interface IFilter<T>
        {
            IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specs);
        }

        public class ColorSpecification : ISpecification<Product>
        {
            public Color Color { get; set; }

            public ColorSpecification(Color color)
            {
                this.Color = color;
            }

            public bool IsSatisfied(Product t) => this.Color == t.Color;
        }

        public class BetterFilter : IFilter<Product>
        {
            public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specs)
            {
                return items.Where(specs.IsSatisfied).Select(s => new Product(s.Name, s.Color, s.Size));
            }
        }
    }
}