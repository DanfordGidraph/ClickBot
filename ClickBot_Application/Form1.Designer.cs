namespace ClickBot_Application
{
    partial class mainForm
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
            this.def_WebBrowser = new System.Windows.Forms.WebBrowser();
            this.def_ProxyCmbBox = new System.Windows.Forms.ComboBox();
            this.sec_WebBrowser = new System.Windows.Forms.WebBrowser();
            this.browserOne_Lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sec_ProxyFileCmbBox = new System.Windows.Forms.ComboBox();
            this.def_SitesCmbBox = new System.Windows.Forms.ComboBox();
            this.sec_SitesFileCmbBox = new System.Windows.Forms.ComboBox();
            this.def_BrowseProxyBtn = new System.Windows.Forms.Button();
            this.def_BrowseSitesBtn = new System.Windows.Forms.Button();
            this.sec_BrowseProxyBtn = new System.Windows.Forms.Button();
            this.sec_BrowseSitesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // def_WebBrowser
            // 
            this.def_WebBrowser.Location = new System.Drawing.Point(151, 12);
            this.def_WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.def_WebBrowser.Name = "def_WebBrowser";
            this.def_WebBrowser.Size = new System.Drawing.Size(389, 458);
            this.def_WebBrowser.TabIndex = 0;
            // 
            // def_ProxyCmbBox
            // 
            this.def_ProxyCmbBox.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_ProxyCmbBox.FormattingEnabled = true;
            this.def_ProxyCmbBox.Location = new System.Drawing.Point(0, 37);
            this.def_ProxyCmbBox.Name = "def_ProxyCmbBox";
            this.def_ProxyCmbBox.Size = new System.Drawing.Size(145, 24);
            this.def_ProxyCmbBox.TabIndex = 1;
            this.def_ProxyCmbBox.Text = "Select Proxies File";
            // 
            // sec_WebBrowser
            // 
            this.sec_WebBrowser.Location = new System.Drawing.Point(546, 12);
            this.sec_WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.sec_WebBrowser.Name = "sec_WebBrowser";
            this.sec_WebBrowser.Size = new System.Drawing.Size(398, 458);
            this.sec_WebBrowser.TabIndex = 2;
            // 
            // browserOne_Lbl
            // 
            this.browserOne_Lbl.AutoSize = true;
            this.browserOne_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.browserOne_Lbl.Font = new System.Drawing.Font("KingsCross", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserOne_Lbl.Location = new System.Drawing.Point(12, 12);
            this.browserOne_Lbl.Name = "browserOne_Lbl";
            this.browserOne_Lbl.Size = new System.Drawing.Size(112, 21);
            this.browserOne_Lbl.TabIndex = 3;
            this.browserOne_Lbl.Text = "First Browser ";
            this.browserOne_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("KingsCross", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Second Browser";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sec_ProxyFileCmbBox
            // 
            this.sec_ProxyFileCmbBox.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec_ProxyFileCmbBox.FormattingEnabled = true;
            this.sec_ProxyFileCmbBox.Location = new System.Drawing.Point(0, 285);
            this.sec_ProxyFileCmbBox.Name = "sec_ProxyFileCmbBox";
            this.sec_ProxyFileCmbBox.Size = new System.Drawing.Size(145, 24);
            this.sec_ProxyFileCmbBox.TabIndex = 5;
            this.sec_ProxyFileCmbBox.Text = "Select Proxies File";
            // 
            // def_SitesCmbBox
            // 
            this.def_SitesCmbBox.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_SitesCmbBox.FormattingEnabled = true;
            this.def_SitesCmbBox.Location = new System.Drawing.Point(0, 67);
            this.def_SitesCmbBox.Name = "def_SitesCmbBox";
            this.def_SitesCmbBox.Size = new System.Drawing.Size(145, 24);
            this.def_SitesCmbBox.TabIndex = 6;
            this.def_SitesCmbBox.Text = "Select Sites File";
            // 
            // sec_SitesFileCmbBox
            // 
            this.sec_SitesFileCmbBox.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec_SitesFileCmbBox.FormattingEnabled = true;
            this.sec_SitesFileCmbBox.Location = new System.Drawing.Point(0, 315);
            this.sec_SitesFileCmbBox.Name = "sec_SitesFileCmbBox";
            this.sec_SitesFileCmbBox.Size = new System.Drawing.Size(145, 24);
            this.sec_SitesFileCmbBox.TabIndex = 7;
            this.sec_SitesFileCmbBox.Text = "Select Sites File";
            // 
            // def_BrowseProxyBtn
            // 
            this.def_BrowseProxyBtn.Font = new System.Drawing.Font("Cooper Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_BrowseProxyBtn.Location = new System.Drawing.Point(0, 98);
            this.def_BrowseProxyBtn.Name = "def_BrowseProxyBtn";
            this.def_BrowseProxyBtn.Size = new System.Drawing.Size(145, 30);
            this.def_BrowseProxyBtn.TabIndex = 8;
            this.def_BrowseProxyBtn.Text = "Browse Proxy File";
            this.def_BrowseProxyBtn.UseVisualStyleBackColor = true;
            // 
            // def_BrowseSitesBtn
            // 
            this.def_BrowseSitesBtn.Font = new System.Drawing.Font("Cooper Std Black", 8.999999F, System.Drawing.FontStyle.Bold);
            this.def_BrowseSitesBtn.Location = new System.Drawing.Point(0, 134);
            this.def_BrowseSitesBtn.Name = "def_BrowseSitesBtn";
            this.def_BrowseSitesBtn.Size = new System.Drawing.Size(145, 30);
            this.def_BrowseSitesBtn.TabIndex = 9;
            this.def_BrowseSitesBtn.Text = "Browse Sites File";
            this.def_BrowseSitesBtn.UseVisualStyleBackColor = true;
            // 
            // sec_BrowseProxyBtn
            // 
            this.sec_BrowseProxyBtn.Font = new System.Drawing.Font("Cooper Std Black", 8.999999F, System.Drawing.FontStyle.Bold);
            this.sec_BrowseProxyBtn.Location = new System.Drawing.Point(0, 345);
            this.sec_BrowseProxyBtn.Name = "sec_BrowseProxyBtn";
            this.sec_BrowseProxyBtn.Size = new System.Drawing.Size(145, 32);
            this.sec_BrowseProxyBtn.TabIndex = 10;
            this.sec_BrowseProxyBtn.Text = "Browse Proxy File";
            this.sec_BrowseProxyBtn.UseVisualStyleBackColor = true;
            // 
            // sec_BrowseSitesBtn
            // 
            this.sec_BrowseSitesBtn.Font = new System.Drawing.Font("Cooper Std Black", 8.999999F, System.Drawing.FontStyle.Bold);
            this.sec_BrowseSitesBtn.Location = new System.Drawing.Point(0, 383);
            this.sec_BrowseSitesBtn.Name = "sec_BrowseSitesBtn";
            this.sec_BrowseSitesBtn.Size = new System.Drawing.Size(145, 32);
            this.sec_BrowseSitesBtn.TabIndex = 11;
            this.sec_BrowseSitesBtn.Text = "Browse Sites File";
            this.sec_BrowseSitesBtn.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 482);
            this.Controls.Add(this.sec_BrowseSitesBtn);
            this.Controls.Add(this.sec_BrowseProxyBtn);
            this.Controls.Add(this.def_BrowseSitesBtn);
            this.Controls.Add(this.def_BrowseProxyBtn);
            this.Controls.Add(this.sec_SitesFileCmbBox);
            this.Controls.Add(this.def_SitesCmbBox);
            this.Controls.Add(this.sec_ProxyFileCmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browserOne_Lbl);
            this.Controls.Add(this.sec_WebBrowser);
            this.Controls.Add(this.def_ProxyCmbBox);
            this.Controls.Add(this.def_WebBrowser);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser def_WebBrowser;
        private System.Windows.Forms.ComboBox def_ProxyCmbBox;
        private System.Windows.Forms.WebBrowser sec_WebBrowser;
        private System.Windows.Forms.Label browserOne_Lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sec_ProxyFileCmbBox;
        private System.Windows.Forms.ComboBox def_SitesCmbBox;
        private System.Windows.Forms.ComboBox sec_SitesFileCmbBox;
        private System.Windows.Forms.Button def_BrowseProxyBtn;
        private System.Windows.Forms.Button def_BrowseSitesBtn;
        private System.Windows.Forms.Button sec_BrowseProxyBtn;
        private System.Windows.Forms.Button sec_BrowseSitesBtn;
    }
}

