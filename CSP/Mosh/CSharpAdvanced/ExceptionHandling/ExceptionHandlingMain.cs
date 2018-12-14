using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpAdvanced.ExceptionHandling
{
    class ExceptionHandlingMain
    {
        public static void Run()
        {
            StreamReader streamReader = null;
            try
            {
                // StreamReader is used for reading any streams of data (files, network, etc)
                streamReader = new StreamReader(@"c:\test\log.txt");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally
            {
                //if(streamReader != null)
                // Make sure that the stream is closed or you may end up keeping files open
                // on the disk or keeping network/database connections open
                    //streamReader.Dispose();

                // Null-Propagation Operator (?.) will return null if anything in the object
                // reference chain is null
                streamReader?.Dispose();
            }

            // Can also be written like this
            // When using the 'using' statement, internally the compiler will create a finally
            // block under the hood and will call the dispose method on the class

            #region Exception Handling w/ using
            //try
            //{
            //    using (var streamReader2 = new StreamReader(@"c:\test\log.txt"))
            //    {
            //        var content = streamReader2.ReadToEnd();
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Sorry, an unexpected error occurred.");
            //}
            #endregion


        }
    }
}
