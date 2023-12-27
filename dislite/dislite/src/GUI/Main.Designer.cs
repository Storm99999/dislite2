namespace dislite.src.GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            this.loginpage.Size = new System.Drawing.Size(1291, 710);
            this.loginpage.TabIndex = 0;
            this.loginpage.ZoomFactor = 1D;
            this.loginpage.Click += new System.EventHandler(this.loginpage_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1291, 710);
            this.Controls.Add(this.loginpage);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginpage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 loginpage;
    }
}