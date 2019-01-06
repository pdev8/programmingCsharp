using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.SOLID.Exercises
{
    public class OpenClosedPrincipleSelf
    {
        public static void Run()
        {
            var productsByGreen = new ProductFilter().FilterBy(new[]
            {
                new Product
                {
                    Name = "Apple",
                    Color = Color.Green,
                    Size = Size.Small
                }, 
                new Product
                {
                    Name = "Tree",
                    Color = Color.Green,
                    Size = Size.Large
                },
                new Product
                {
                    Name = "Shirt",
                    Color = Color.Blue,
                    Size = Size.Medium
                } 
            }, new AndSpecification<Product>(new ColorSpecification(Color.Green), new SizeSpecification(Size.Small)));

            foreach (var product in productsByGreen)
            {
                Console.WriteLine($"Product: {product.Name}, color: {product.Color} and size: {product.Size}");
            }
        }
    }

    public interface IFilter<T>
    {
        IEnumerable<T> FilterBy(IEnumerable<T> items, ISpecification<T> specification);
    }

    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private readonly Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == this.color;
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == this.size;
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> first, second;

        public AndSpecification(
            ISpecification<T> first,
            ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }

    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> FilterBy(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            return items.Where(specification.IsSatisfied);
        }
    }

    public class Product
    {
        public string Name { get; set; }

        public Color Color { get; set; }

        public Size Size { get; set; }
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
}