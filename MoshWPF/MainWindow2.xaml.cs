using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MoshWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //DownloadHtmlAsync("https://www.google.com/");
            var html = await GetHtmlAsync("http://msdn.microsoft.com");
            MessageBox.Show(html.Substring(0, 10));
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\test\googleHtml.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\test\googleHtml.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
