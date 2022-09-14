
namespace Presentation
{
    partial class OgunVerileriGirisEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgunVerileriGirisEkrani));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_ogunTarih = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel13 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmb_ogunler = new System.Windows.Forms.ComboBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgv_besinler = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btn_ekle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_besinAdi = new System.Windows.Forms.TextBox();
            this.btn_arama = new System.Windows.Forms.Button();
            this.btn_cikis = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_diyetisyenYorumGoruntule = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtp_yorumTarihi = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.rtb_yorumGoruntuleme = new System.Windows.Forms.RichTextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_besinler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.bunifuLabel2);
            this.panel1.Controls.Add(this.rtb_yorumGoruntuleme);
            this.panel1.Controls.Add(this.btn_diyetisyenYorumGoruntule);
            this.panel1.Controls.Add(this.dtp_yorumTarihi);
            this.panel1.Controls.Add(this.btn_cikis);
            this.panel1.Controls.Add(this.btn_arama);
            this.panel1.Controls.Add(this.txt_besinAdi);
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.dgv_besinler);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuLabel13);
            this.panel1.Controls.Add(this.cmb_ogunler);
            this.panel1.Controls.Add(this.dtp_ogunTarih);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 451);
            this.panel1.TabIndex = 5;
            // 
            // dtp_ogunTarih
            // 
            this.dtp_ogunTarih.BackColor = System.Drawing.Color.Transparent;
            this.dtp_ogunTarih.BorderColor = System.Drawing.Color.Silver;
            this.dtp_ogunTarih.BorderRadius = 1;
            this.dtp_ogunTarih.Color = System.Drawing.Color.Silver;
            this.dtp_ogunTarih.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtp_ogunTarih.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtp_ogunTarih.DisabledColor = System.Drawing.Color.Gray;
            this.dtp_ogunTarih.DisplayWeekNumbers = false;
            this.dtp_ogunTarih.DPHeight = 0;
            this.dtp_ogunTarih.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_ogunTarih.FillDatePicker = false;
            this.dtp_ogunTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ogunTarih.ForeColor = System.Drawing.Color.Black;
            this.dtp_ogunTarih.Icon = ((System.Drawing.Image)(resources.GetObject("dtp_ogunTarih.Icon")));
            this.dtp_ogunTarih.IconColor = System.Drawing.Color.Gray;
            this.dtp_ogunTarih.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtp_ogunTarih.LeftTextMargin = 5;
            this.dtp_ogunTarih.Location = new System.Drawing.Point(12, 23);
            this.dtp_ogunTarih.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtp_ogunTarih.Name = "dtp_ogunTarih";
            this.dtp_ogunTarih.Size = new System.Drawing.Size(172, 32);
            this.dtp_ogunTarih.TabIndex = 41;
            // 
            // bunifuLabel13
            // 
            this.bunifuLabel13.AllowParentOverrides = false;
            this.bunifuLabel13.AutoEllipsis = false;
            this.bunifuLabel13.CursorType = null;
            this.bunifuLabel13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel13.Location = new System.Drawing.Point(14, 56);
            this.bunifuLabel13.Name = "bunifuLabel13";
            this.bunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel13.Size = new System.Drawing.Size(68, 16);
            this.bunifuLabel13.TabIndex = 25;
            this.bunifuLabel13.Text = "Öğün Seçimi";
            this.bunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmb_ogunler
            // 
            this.cmb_ogunler.FormattingEnabled = true;
            this.cmb_ogunler.Location = new System.Drawing.Point(14, 74);
            this.cmb_ogunler.Name = "cmb_ogunler";
            this.cmb_ogunler.Size = new System.Drawing.Size(172, 21);
            this.cmb_ogunler.TabIndex = 24;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 97);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(46, 16);
            this.bunifuLabel1.TabIndex = 44;
            this.bunifuLabel1.Text = "Besin Adı";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgv_besinler
            // 
            this.dgv_besinler.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_besinler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_besinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_besinler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_besinler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_besinler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_besinler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_besinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_besinler.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_besinler.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_besinler.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_besinler.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_besinler.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_besinler.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_besinler.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_besinler.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_besinler.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_besinler.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_besinler.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_besinler.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_besinler.CurrentTheme.Name = null;
            this.dgv_besinler.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_besinler.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_besinler.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_besinler.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_besinler.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_besinler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_besinler.EnableHeadersVisualStyles = false;
            this.dgv_besinler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_besinler.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_besinler.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_besinler.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_besinler.Location = new System.Drawing.Point(12, 144);
            this.dgv_besinler.Name = "dgv_besinler";
            this.dgv_besinler.RowHeadersVisible = false;
            this.dgv_besinler.RowTemplate.Height = 40;
            this.dgv_besinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_besinler.Size = new System.Drawing.Size(779, 262);
            this.dgv_besinler.TabIndex = 45;
            this.dgv_besinler.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btn_ekle
            // 
            this.btn_ekle.ActiveBorderThickness = 1;
            this.btn_ekle.ActiveCornerRadius = 20;
            this.btn_ekle.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.btn_ekle.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_ekle.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.BackgroundImage")));
            this.btn_ekle.ButtonText = "Ekle";
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.Black;
            this.btn_ekle.IdleBorderThickness = 1;
            this.btn_ekle.IdleCornerRadius = 20;
            this.btn_ekle.IdleFillColor = System.Drawing.Color.Gold;
            this.btn_ekle.IdleForecolor = System.Drawing.Color.Black;
            this.btn_ekle.IdleLineColor = System.Drawing.Color.Gold;
            this.btn_ekle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ekle.Location = new System.Drawing.Point(283, 411);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(105, 36);
            this.btn_ekle.TabIndex = 46;
            this.btn_ekle.TabStop = false;
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_besinAdi
            // 
            this.txt_besinAdi.Location = new System.Drawing.Point(12, 116);
            this.txt_besinAdi.Name = "txt_besinAdi";
            this.txt_besinAdi.Size = new System.Drawing.Size(172, 20);
            this.txt_besinAdi.TabIndex = 47;
            // 
            // btn_arama
            // 
            this.btn_arama.BackColor = System.Drawing.Color.Gold;
            this.btn_arama.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_arama.ForeColor = System.Drawing.Color.Black;
            this.btn_arama.Location = new System.Drawing.Point(190, 115);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(75, 23);
            this.btn_arama.TabIndex = 48;
            this.btn_arama.Text = "Arama";
            this.btn_arama.UseVisualStyleBackColor = false;
            // 
            // btn_cikis
            // 
            this.btn_cikis.ActiveBorderThickness = 1;
            this.btn_cikis.ActiveCornerRadius = 20;
            this.btn_cikis.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.btn_cikis.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_cikis.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.btn_cikis.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.ButtonText = "Çıkış";
            this.btn_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cikis.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.Black;
            this.btn_cikis.IdleBorderThickness = 1;
            this.btn_cikis.IdleCornerRadius = 20;
            this.btn_cikis.IdleFillColor = System.Drawing.Color.Gold;
            this.btn_cikis.IdleForecolor = System.Drawing.Color.Black;
            this.btn_cikis.IdleLineColor = System.Drawing.Color.Gold;
            this.btn_cikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cikis.Location = new System.Drawing.Point(396, 411);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(105, 36);
            this.btn_cikis.TabIndex = 49;
            this.btn_cikis.TabStop = false;
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cikis.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btn_diyetisyenYorumGoruntule
            // 
            this.btn_diyetisyenYorumGoruntule.ActiveBorderThickness = 1;
            this.btn_diyetisyenYorumGoruntule.ActiveCornerRadius = 20;
            this.btn_diyetisyenYorumGoruntule.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.btn_diyetisyenYorumGoruntule.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_diyetisyenYorumGoruntule.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.btn_diyetisyenYorumGoruntule.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_diyetisyenYorumGoruntule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_diyetisyenYorumGoruntule.BackgroundImage")));
            this.btn_diyetisyenYorumGoruntule.ButtonText = "Diyetisyen Yorum Görüntüle";
            this.btn_diyetisyenYorumGoruntule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_diyetisyenYorumGoruntule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_diyetisyenYorumGoruntule.ForeColor = System.Drawing.Color.Black;
            this.btn_diyetisyenYorumGoruntule.IdleBorderThickness = 1;
            this.btn_diyetisyenYorumGoruntule.IdleCornerRadius = 20;
            this.btn_diyetisyenYorumGoruntule.IdleFillColor = System.Drawing.Color.Gold;
            this.btn_diyetisyenYorumGoruntule.IdleForecolor = System.Drawing.Color.Black;
            this.btn_diyetisyenYorumGoruntule.IdleLineColor = System.Drawing.Color.Gold;
            this.btn_diyetisyenYorumGoruntule.Location = new System.Drawing.Point(612, 7);
            this.btn_diyetisyenYorumGoruntule.Margin = new System.Windows.Forms.Padding(4);
            this.btn_diyetisyenYorumGoruntule.Name = "btn_diyetisyenYorumGoruntule";
            this.btn_diyetisyenYorumGoruntule.Size = new System.Drawing.Size(178, 36);
            this.btn_diyetisyenYorumGoruntule.TabIndex = 51;
            this.btn_diyetisyenYorumGoruntule.TabStop = false;
            this.btn_diyetisyenYorumGoruntule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_yorumTarihi
            // 
            this.dtp_yorumTarihi.BackColor = System.Drawing.Color.Transparent;
            this.dtp_yorumTarihi.BorderColor = System.Drawing.Color.Silver;
            this.dtp_yorumTarihi.BorderRadius = 1;
            this.dtp_yorumTarihi.Color = System.Drawing.Color.Silver;
            this.dtp_yorumTarihi.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtp_yorumTarihi.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtp_yorumTarihi.DisabledColor = System.Drawing.Color.Gray;
            this.dtp_yorumTarihi.DisplayWeekNumbers = false;
            this.dtp_yorumTarihi.DPHeight = 0;
            this.dtp_yorumTarihi.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_yorumTarihi.FillDatePicker = false;
            this.dtp_yorumTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_yorumTarihi.ForeColor = System.Drawing.Color.Black;
            this.dtp_yorumTarihi.Icon = ((System.Drawing.Image)(resources.GetObject("dtp_yorumTarihi.Icon")));
            this.dtp_yorumTarihi.IconColor = System.Drawing.Color.Gray;
            this.dtp_yorumTarihi.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtp_yorumTarihi.LeftTextMargin = 5;
            this.dtp_yorumTarihi.Location = new System.Drawing.Point(425, 11);
            this.dtp_yorumTarihi.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtp_yorumTarihi.Name = "dtp_yorumTarihi";
            this.dtp_yorumTarihi.Size = new System.Drawing.Size(180, 32);
            this.dtp_yorumTarihi.TabIndex = 50;
            // 
            // rtb_yorumGoruntuleme
            // 
            this.rtb_yorumGoruntuleme.Location = new System.Drawing.Point(425, 49);
            this.rtb_yorumGoruntuleme.Name = "rtb_yorumGoruntuleme";
            this.rtb_yorumGoruntuleme.Size = new System.Drawing.Size(366, 89);
            this.rtb_yorumGoruntuleme.TabIndex = 52;
            this.rtb_yorumGoruntuleme.Text = "";
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 5);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(62, 16);
            this.bunifuLabel2.TabIndex = 53;
            this.bunifuLabel2.Text = "Tarih Seçimi";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // OgunVerileriGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.panel1);
            this.Name = "OgunVerileriGirisEkrani";
            this.Text = "OgunVerileriGirisEkrani";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_besinler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDatePicker dtp_ogunTarih;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_besinler;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel13;
        private System.Windows.Forms.ComboBox cmb_ogunler;
        private System.Windows.Forms.TextBox txt_besinAdi;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ekle;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cikis;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.RichTextBox rtb_yorumGoruntuleme;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_diyetisyenYorumGoruntule;
        private Bunifu.UI.WinForms.BunifuDatePicker dtp_yorumTarihi;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}