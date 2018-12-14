using System;

namespace CSP.PluralSight.CollectionsGenerics.Arrays
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        #region Constructors
        public Product()
        {
            // Implicit declaration
            //var colorOptions = new string[4];
            //colorOptions[0] = "Red";
            //colorOptions[1] = "Espresso";
            //colorOptions[2] = "White";
            //colorOptions[3] = "Navy";

            // Collection Initializer
            string[] colorOptions = { "Red", "Espresso", "White", "Navy" };

            // System.Array static method
            int brownIndex = Array.IndexOf(colorOptions, "Espresso");

            // System.Array instance method
            colorOptions.SetValue("Blue", 0);

            // foreach is read-only
            foreach (var color in colorOptions)
            {
                // C# 6 string interpolation
                Console.WriteLine($"The color is {color}");

                // VS 2013 String.Format()
                // string s = String.Format("The color is {0}", color);
                // Console.WriteLine(s);
            }

            // Will print the object type
            Console.WriteLine(colorOptions);
        }

        public Product(int productId, string productName, string description) : this()
        {
            ProductId = productId;
            ProductName = productName;
            Description = description;
        }
        #endregion

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
    }
}
