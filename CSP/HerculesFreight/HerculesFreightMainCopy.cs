using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSP.HerculesFreight
{
    public class HerculesFreightMainCopy
    {
        public static void Run()
        {
            var option = new ChromeOptions();
            option.AddArguments("incognito");
            option.AddArguments("no-sandbox");

            var driver = new ChromeDriver(@"C:\Users\ppauleee\Documents\EFS\Selenium\chromedriver_win32", option);

            ////for (var i = 1; i < 75; i++)
            ////{
            ////    Console.WriteLine(i);

            ////    driver.ExecuteScript($"window.open('https://herculesfreight.com/quoteApiCustomerXML.php?U3VibWl0&cn=MTkxNjIw&oZip=91710&dZip=97301&billterm=PPD&Clky[0]=175&Weight[0]=365&&PLT=1', 'tab{i}');");
            ////    driver.SwitchTo().Window(driver.WindowHandles[i]);

            ////    var body = driver.FindElements(By.Name("body"));

            ////    var instances = driver.FindElements(By.ClassName("collapsible"));

            ////    var instancesOfTotalFund = instances.Where(s => s.Text.ToLower().Contains("Total US Funds".ToLower())).ToList();

            ////    var responseText = instancesOfTotalFund.FirstOrDefault();

            ////    var response = (DETAILS)new XmlSerializer(typeof(DETAILS)).Deserialize(new StringReader(responseText?.Text ?? throw new Exception("There was an error with the node.")));

            ////    if (response.RowItem.FirstOrDefault(s => string.Equals(s.Description, "Total US Funds", StringComparison.OrdinalIgnoreCase))?.Charges != (decimal)223.18)
            ////    {
            ////        throw new Exception($"Quote {(int)(response.fromtosection.RateQuote)} response charge was {response.RowItem.First(s => string.Equals(s.Description, "Total US Funds", StringComparison.OrdinalIgnoreCase)).Charges}; did not match expected price of $223.18.");
            ////    }
            ////}


            driver.Navigate().GoToUrl("https://herculesfreight.com/");

            for (var i = 0; i < 100; i++)
            {
                driver.ExecuteScript($"window.open('quoteApiCustomerXML.php?U3VibWl0&cn=MTkxNjIw&oZip=91710&dZip=97301&billterm=PPD&Clky[0]=175&Weight[0]=365&&PLT=1', 'tab{i}');");
            }
        }
    }
}