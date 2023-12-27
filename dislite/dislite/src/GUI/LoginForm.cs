using dislite.Properties;
using dislite.src.GUI;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace dislite
{
    public partial class LoginForm : Form
    {
        private Main main = new Main();
        public LoginForm()
        {
            InitializeComponent();
            loginpage.CoreWebView2InitializationCompleted += loginpage_CoreWebView2InitializationCompleted;
            loginpage.WebMessageReceived += loginpage_WebMessageReceived;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            main.Hide();
            Blurtil.EnableAcrylic(this, Color.FromArgb(Settings.Default.blurAmount, 30, 32, 61));

            // Login page with WV2
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\dependencies\\html\\";
            string htmlFilePath = Path.Combine(baseDirectory, "login.html");
            loginpage.Source = new Uri(htmlFilePath);
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(0, 69, 69, 82)); // Needed, so the blur can function properly.
        }

        private void loginpage_Click(object sender, EventArgs e)
        {

        }

        private void HandleJavascript(string x) 
        {
            Settings.Default.token = x;
            Settings.Default.Save();
            main.Show();
            Hide();
        }

        private void loginpage_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            string message = e.TryGetWebMessageAsString();
            if (!string.IsNullOrEmpty(message))
            {
                HandleJavascript(message);
            }
        }

        private async void loginpage_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            // ;3
            await loginpage.CoreWebView2.ExecuteScriptAsync("window.external = { invoke: function(arg) { window.chrome.webview.postMessage(arg); } };");
        }
    }
}
