using DietProject.DAL.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProject.UI
{
    public partial class KullanıcıGirisEkranı : Form
    {
        public KullanıcıGirisEkranı()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            AnaGirisEkranı anaGirisEkranı = new AnaGirisEkranı();
            this.Close();
            anaGirisEkranı.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string eposta = txtEposta.Text;
           Kullanici eslesenKullanici = new Kullanici();
            //foreach (Kullanici kullanici in Kullanicilar)
            //{
            //    if (kullanici.Eposta == eposta)
            //    {
            //        eslesenKullanici = kullanici;
                    
            //    }
            //    else
            //    {
            //        MessageBox.Show("Yanlış eposta adresi girdiniz.");
            //    }
            //}
            //string sifre = txtSifre.Text;

            //foreach (Kullanici kullanici in Kullanicilar)
            //{
            //    if (kullanici.Sifre == sifre)
            //    {
            //        eslesenKullanici = kullanici;

            //    }
            //    else
            //    {
            //        MessageBox.Show("Yanlış şifre adresi girdiniz.");
            //    }
            //}
            //if (eslesenKullanici.UserStatus == "1")
            //{
            //    NormalKullanıcıAnaEkranı normalKullanıcıAnaEkranı = new NormalKullanıcıAnaEkranı();
            //    normalKullanıcıAnaEkranı.ShowDialog();
            //    this.Hide();
            //}
            //else if(eslesenKullanici.UserStatus == "2")
            //{
            //    AdminAnaEkranı adminAnaEkranı = new AdminAnaEkranı();
            //    adminAnaEkranı.ShowDialog();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Giriş işlemi başarısız.");
            //}

            

        }
    }
}
