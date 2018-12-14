using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.SOLID
{
    public class OpenClosedPrinciple
    {
        public class BadPrinciple
        {
            public enum Color
            {
                Red,
                Green,
                Blue,
                Yellow,
                Orange
            }

            public enum Size
            {
                Small,
                Medium,
                Large
            }

            public class Product
            {
                public string Name;
                public Color Color;
                public Size Size;

                public Product(string name, Color color, Size size)
                {
                    this.Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
                    this.Color = color;
                    this.Size = size;
                }
            }

            public static class ProductFilter
            {
                public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
                {
                    foreach (var product in products)
                    {
                        if (product.Size == size)
                        {
                            yield return product;
                        }
                    }
                }

                public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
                {
                    foreach (var product in products)
                    {
                        if (product.Color == color)
                        {
                            yield return product;
                        }
                    }
                }
            }
        }

        public class GoodPrinciple
        {
            public interface ISpecification<T>
            {
                bool IsSatisfied(T t);
            }

            public interface IFilter<T>
            {
                IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specs);
            }

            public class ColorSpecification : ISpecification<BadPrinciple.Product>
            {
                private BadPrinciple.Color color;

                public ColorSpecification(BadPrinciple.Color color)
                {
                    this.color = color;
                }

                public bool IsSatisfied(BadPrinciple.Product t)
                {
                    return t.Color == this.color;
                }
            }

            public class SizeSpecification : ISpecification<BadPrinciple.Product>
            {
                private BadPrinciple.Size size;

                public SizeSpecification(BadPrinciple.Size size)
                {
                    this.size = size;
                }

                public bool IsSatisfied(BadPrinciple.Product t)
                {
                    return t.Size == this.size;
                }
            }

            public class AndSpecification<T> : ISpecification<T>
            {
                private ISpecification<T> first, second;

                public AndSpecification(ISpecification<T> first, ISpecification<T> second)
                {
                    this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
                    this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
                }

                public bool IsSatisfied(T t)
                {
                    return first.IsSatisfied(t) && second.IsSatisfied(t);
                }
            }

            public class BetterFilter : IFilter<BadPrinciple.Product>
            {
                public IEnumerable<BadPrinciple.Product> Filter(IEnumerable<BadPrinciple.Product> items, ISpecification<BadPrinciple.Product> specs)
                {
                    foreach (var item in items)
                    {
                        if (specs.IsSatisfied(item))
                        {
                            yield return item;
                        }
                    }
                }
            }
        }

        public static void Run()
        {
            var phone = new BadPrinciple.Product("iPhone", BadPrinciple.Color.Red, BadPrinciple.Size.Small);
            var toothbrush = new BadPrinciple.Product("Toothbrush", BadPrinciple.Color.Yellow, BadPrinciple.Size.Small);
            var hydroflask = new BadPrinciple.Product("Hydro Flask", BadPrinciple.Color.Red, BadPrinciple.Size.Medium);

            var products = new[] { phone, toothbrush, hydroflask };

            BadPrinciple.ProductFilter.FilterByColor(products, BadPrinciple.Color.Red).Select((item, index) => new {item, index}).ToList().ForEach(s =>
            {
                var i = s.index;
                Console.WriteLine($"Product {++i}: {s.item.Color} {s.item.Name}");
            });

            var bf = new GoodPrinciple.BetterFilter();
            bf.Filter(products, new GoodPrinciple.ColorSpecification(BadPrinciple.Color.Red)).ToList().ForEach(s => Console.WriteLine($"Product: {s.Color} {s.Name}"));
        }
    }
}