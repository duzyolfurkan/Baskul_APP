
namespace Presentation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_girisYap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_uyeOl = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_uyeOlmadanDevam = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cikisYap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_copyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(213, 123);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(164, 166);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.lbl_copyright);
            this.panel1.Controls.Add(this.btn_cikisYap);
            this.panel1.Controls.Add(this.btn_uyeOlmadanDevam);
            this.panel1.Controls.Add(this.btn_uyeOl);
            this.panel1.Controls.Add(this.btn_girisYap);
            this.panel1.Controls.Add(this.pb_logo);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 451);
            this.panel1.TabIndex = 1;
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.ActiveBorderThickness = 1;
            this.btn_girisYap.ActiveCornerRadius = 20;
            this.btn_girisYap.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.btn_girisYap.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_girisYap.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.btn_girisYap.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_girisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_girisYap.BackgroundImage")));
            this.btn_girisYap.ButtonText = "Giriş Yap";
            this.btn_girisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_girisYap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisYap.ForeColor = System.Drawing.Color.Black;
            this.btn_girisYap.IdleBorderThickness = 1;
            this.btn_girisYap.IdleCornerRadius = 20;
            this.btn_girisYap.IdleFillColor = System.Drawing.Color.Gold;
            this.btn_girisYap.IdleForecolor = System.Drawing.Color.Black;
            this.btn_girisYap.IdleLineColor = System.Drawing.Color.Gold;
            this.btn_girisYap.Location = new System.Drawing.Point(397, 120);
            this.btn_girisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(169, 36);
            this.btn_girisYap.TabIndex = 2;
            this.btn_girisYap.TabStop = false;
            this.btn_girisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // btn_uyeOl
            // 
            this.btn_uyeOl.ActiveBorderThickness = 1;
            this.btn_uyeOl.ActiveCornerRadius = 20;
            this.btn_uyeOl.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.btn_uyeOl.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_uyeOl.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.btn_uyeOl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_uyeOl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_uyeOl.BackgroundImage")));
            this.btn_uyeOl.ButtonText = "Üye Ol";
            this.btn_uyeOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uyeOl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeOl.ForeColor = System.Drawing.Color.Black;
            this.btn_uyeOl.IdleBorderThickness = 1;
            this.btn_uyeOl.IdleCornerRadius = 20;
            this.btn_uyeOl.IdleFillColor = System.Drawing.Color.Gold;
            this.btn_uyeOl.IdleForecolor = System.Drawing.Color.Black;
            this.btn_uyeOl.IdleLineColor = System.Drawing.Color.Gold;
            this.btn_uyeOl.Location = new System.Drawing.Point(397, 164);
            this.btn_uyeOl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_uyeOl.Name = "btn_uyeOl";
            this.btn_uyeOl.Size = new System.Drawing.Size(169, 36);
            this.btn_uyeOl.TabIndex = 3;
            this.btn_uyeOl.TabStop = false;
            this.btn_uyeOl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_uyeOl.Click += new System.EventHandler(this.btn_uyeOl_Click);
            // 
            // btn_uyeOlmadanDevam
            // 
            this.btn_uyeOlmadanDevam.ActiveBorderThickness = 1;
            this.btn_uyeOlmadanDevam.ActiveCornerRadius = 20;
            this.btn_uyeOlmadanDevam.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.btn_uyeOlmadanDevam.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_uyeOlmadanDevam.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.btn_uyeOlmadanDevam.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_uyeOlmadanDevam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_uyeOlmadanDevam.BackgroundImage")));
            this.btn_uyeOlmadanDevam.ButtonText = "Üyeliksiz İşlemler";
            this.btn_uyeOlmadanDevam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uyeOlmadanDevam.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeOlmadanDevam.ForeColor = System.Drawing.Color.Black;
            this.btn_uyeOlmadanDevam.IdleBorderThickness = 1;
            this.btn_uyeOlmadanDevam.IdleCornerRadius = 20;
            this.btn_uyeOlmadanDevam.IdleFillColor = System.Drawing.Color.Gold;
            this.btn_uyeOlmadanDevam.IdleForecolor = System.Drawing.Color.Black;
            this.btn_uyeOlmadanDevam.IdleLineColor = System.Drawing.Color.Gold;
            this.btn_uyeOlmadanDevam.Location = new System.Drawing.Point(397, 208);
            this.btn_uyeOlmadanDevam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_uyeOlmadanDevam.Name = "btn_uyeOlmadanDevam";
            this.btn_uyeOlmadanDevam.Size = new System.Drawing.Size(169, 36);
            this.btn_uyeOlmadanDevam.TabIndex = 4;
            this.btn_uyeOlmadanDevam.TabStop = false;
            this.btn_uyeOlmadanDevam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_uyeOlmadanDevam.Click += new System.EventHandler(this.btn_uyeOlmadanDevam_Click);
            // 
            // btn_cikisYap
            // 
            this.btn_cikisYap.ActiveBorderThickness = 1;
            this.btn_cikisYap.ActiveCornerRadius = 20;
            this.btn_cikisYap.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.btn_cikisYap.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_cikisYap.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.btn_cikisYap.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_cikisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikisYap.BackgroundImage")));
            this.btn_cikisYap.ButtonText = "Çıkış";
            this.btn_cikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cikisYap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikisYap.ForeColor = System.Drawing.Color.Black;
            this.btn_cikisYap.IdleBorderThickness = 1;
            this.btn_cikisYap.IdleCornerRadius = 20;
            this.btn_cikisYap.IdleFillColor = System.Drawing.Color.Gold;
            this.btn_cikisYap.IdleForecolor = System.Drawing.Color.Black;
            this.btn_cikisYap.IdleLineColor = System.Drawing.Color.Gold;
            this.btn_cikisYap.Location = new System.Drawing.Point(397, 252);
            this.btn_cikisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cikisYap.Name = "btn_cikisYap";
            this.btn_cikisYap.Size = new System.Drawing.Size(169, 36);
            this.btn_cikisYap.TabIndex = 5;
            this.btn_cikisYap.TabStop = false;
            this.btn_cikisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.AutoSize = true;
            this.lbl_copyright.Location = new System.Drawing.Point(3, 433);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(131, 13);
            this.lbl_copyright.TabIndex = 6;
            this.lbl_copyright.Text = "© Copyright Baskül - 2022";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_girisYap;
        private System.Windows.Forms.Label lbl_copyright;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cikisYap;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_uyeOlmadanDevam;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_uyeOl;
    }
}

