using dislite.Properties;
using dislite.src.API;
using dislite.src.UTILS;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dislite.src.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            loginpage.CoreWebView2InitializationCompleted += loginpage_CoreWebView2InitializationCompleted;
            loginpage.WebMessageReceived += loginpage_WebMessageReceived;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;  
            Size = SystemInformation.WorkingArea.Size;
            Location = SystemInformation.WorkingArea.Location;
        }

        private void loginpage_Click(object sender, EventArgs e)
        {

        }

        private async void loginpage_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            string message = e.TryGetWebMessageAsString();
            if (!string.IsNullOrEmpty(message))
            {
                await Parser.ParseContext(message, loginpage);
            }
        }

        private async void loginpage_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            // ;3
            await loginpage.CoreWebView2.ExecuteScriptAsync("window.external = { invoke: function(arg) { window.chrome.webview.postMessage(arg); } };");
            await Task.Delay(500);
            // This is self explainatory, right?
            await loginpage.ExecuteScriptAsync($"setToken(`{Settings.Default.token}`);");
            await loginpage.ExecuteScriptAsync($"updateUser();");
            await loginpage.ExecuteScriptAsync("clearChannels();");
            await loginpage.ExecuteScriptAsync("clearGuilds();");
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\dependencies\\html\\";
            string htmlFilePath = Path.Combine(baseDirectory, "discordview.html");
            loginpage.Source = new Uri(htmlFilePath);

            await MessageLoader.TryLoadMessages(loginpage, null);
        }
    }
}
