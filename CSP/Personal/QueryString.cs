using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Personal
{
    public class QueryString
    {
        public static void Run()
        {
            var request = new RequestModel
            {
                Value1 = "value1",
                Value2 = "value2",
                Value3 = "value3"
            };

            Console.WriteLine(string.Join("&", request.GetType().GetProperties().Select(s => string.Format($"{s.Name}={s.GetValue(request)}"))));
        }
    }

    public class RequestModel
    {
        public string Value1 { get; set; }

        public string Value2 { get; set; }

        public string Value3 { get; set; }
    }
}
