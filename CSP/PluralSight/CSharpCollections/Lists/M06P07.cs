using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpCollections.Lists
{
    class M06P07
    {
        public static void Run()
        {
            ObservableCollection<string> toppings = new ObservableCollection<string>()
            {
                "Pepperoni",
                "Jalapeno",
                "Sausage"
            };

            // Hooking it up to an event handler
            toppings.CollectionChanged += OnCollectionChanged;

            toppings.Add("Mushrooms");
            toppings.Remove("Jalapeno");

            foreach (string topping in toppings)
            {
                Console.WriteLine(topping);
            }
        }

        static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            
        }
    }
}
