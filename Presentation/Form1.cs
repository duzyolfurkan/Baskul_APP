using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_uyeOl_Click(object sender, EventArgs e)
        {
            //Üyelik oluşturma ekranına erişim sağlandı, önceki formun kapatılması sağlandı
            UyelikOlusturmaEkrani uyelikOlusturmaEkrani = new UyelikOlusturmaEkrani();
            this.Hide();
            uyelikOlusturmaEkrani.ShowDialog();
           
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            //İlgili butona formu kapatma özelliği verildi
            this.Close();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            //Üye giriş ekranına erişim sağlandı, önceki formun kapatılması sağlandı
            UyeGirisEkrani uyeGirisEkrani = new UyeGirisEkrani();
            this.Hide();
            uyeGirisEkrani.ShowDialog();
        }

        private void btn_uyeOlmadanDevam_Click(object sender, EventArgs e)
        {
            //Üyeliksiz işlemler ekranına erişim sağlandı, önceki formun kapatılması sağlandı
            UyeliksizIslemlerEkrani uyeliksizIslemlerEkrani = new UyeliksizIslemlerEkrani();
            this.Hide();
            uyeliksizIslemlerEkrani.ShowDialog();
        }
    }
}
