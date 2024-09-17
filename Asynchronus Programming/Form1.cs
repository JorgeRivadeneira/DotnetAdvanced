using System.Net;

namespace Asynchronus_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DownloadHtmlAsync("https://www.cnn.com");
            var html = await  GetHtmlAsync("https://github.com");
            MessageBox.Show(html.Substring(0, 100));
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var sw = new StreamWriter(@"C:\Data\result.html"))
            {
                await sw.WriteLineAsync(html);
            }
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var sw = new StreamWriter(@"C:\Data\result.html"))
            {
                sw.WriteLine(html);
            }
        }
    }
}
