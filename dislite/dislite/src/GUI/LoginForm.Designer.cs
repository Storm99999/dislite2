namespace dislite
{
    partial class LoginForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginpage = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.loginpage)).BeginInit();
            this.SuspendLayout();
            // 
            // loginpage
            // 
            this.loginpage.AllowExternalDrop = true;
            this.loginpage.CreationProperties = null;
            this.loginpage.DefaultBackgroundColor = System.Drawing.Color.White;
            this.loginpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpage.Location = new System.Drawing.Point(0, 0);
            this.loginpage.Name = "loginpage";
            this.loginpage.Size = new System.Drawing.Size(993, 626);
            this.loginpage.TabIndex = 0;
            this.loginpage.ZoomFactor = 1D;
            this.loginpage.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.loginpage_CoreWebView2InitializationCompleted);
            this.loginpage.WebMessageReceived += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>(this.loginpage_WebMessageReceived);
            this.loginpage.Click += new System.EventHandler(this.loginpage_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(993, 626);
            this.Controls.Add(this.loginpage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.loginpage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 loginpage;
    }
}

