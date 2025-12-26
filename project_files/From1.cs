using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace Amazon
{
    public partial class Form1 : Form
    {
        private WebView2 _webView;
        private string _iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "amazon.ico");

        public Form1()
        {
            InitializeComponent();
            this.Text = "Amazon Shopping for Desktop";
            this.Size = new Size(1400, 900);
            this.StartPosition = FormStartPosition.CenterScreen;
            
            if (File.Exists(_iconPath)) {
                try { this.Icon = new Icon(_iconPath); } catch { }
            }

            InitializeAmazon();
        }

        private async void InitializeAmazon()
        {
            _webView = new WebView2 { Dock = DockStyle.Fill };
            this.Controls.Add(_webView);

            string userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AmazonShoppingforDesktop_Data");
            var env = await CoreWebView2Environment.CreateAsync(null, userDataFolder);
            
            await _webView.EnsureCoreWebView2Async(env);

            // Externe Links im System-Browser öffnen
            _webView.CoreWebView2.NewWindowRequested += (s, e) =>
            {
                e.Handled = true;
                Process.Start(new ProcessStartInfo(e.Uri) { UseShellExecute = true });
            };

            _webView.Source = new Uri("https://amazon.com/");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _webView?.Dispose();
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}
