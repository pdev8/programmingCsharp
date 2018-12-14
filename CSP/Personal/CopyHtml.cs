using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace CSP.Personal
{
    public class CopyHtml
    {
        public async void Run()
        {
            await DownloadHtmlAsync("https://www.bbc.com/news/world-asia-44761821");
        }

        // Asynchronous Version
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(new Uri(url));

            using (var streamWriter = new StreamWriter(@"C:\test\test2.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        // Synchronous Version
        public static void DownloadHtml(string url)
        {
            using (var webClient = new WebClient())
            {
                var html = webClient.DownloadString(url);

                using (var streamWriter = new StreamWriter(@"C:\test\test.html"))
                {
                    streamWriter.Write(html);
                }
            }
        }
    }
}
