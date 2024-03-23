//using DietProject.DAL.Entities;
using DietProject.BLL;
using DietProject.BLL.Manager.Concrete;
using DietProject.BLL.Models;
using DietProject.DAL.Context;
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
    public partial class frm_KullaniciGirisEkrani : Form
    {
        //public KullaniciModel kullanicilar = new KullaniciModel();
        public frm_KullaniciGirisEkrani()
        {
            InitializeComponent();
            
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            frm_AnaGirisEkrani anaGirisEkranı = new frm_AnaGirisEkrani();
            this.Close();
            anaGirisEkranı.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            KullaniciManager kullaniciManager = new KullaniciManager();

            bool kullanicibul = false;

            foreach (KullaniciModel kullanici in kullaniciManager.GetAllWithIncludes())
            {
                if (kullanici.Eposta == txtEposta.Text && kullanici.Sifre == txtSifre.Text)
                {
                    kullanicibul = true;

                    if (kullanici.UserStatus == UserStatus.Admin)
                    {
                        frm_AdminAnaEkrani adminAnaEkranı = new frm_AdminAnaEkrani();
                        adminAnaEkranı.Show();
                    }
                    else if (kullanici.UserStatus == UserStatus.NormalKullanici)
                    {
                        frm_NormalKullaniciAnaEkrani normalKullaniciAnaEkrani = new frm_NormalKullaniciAnaEkrani();
                        normalKullaniciAnaEkrani.Show();
                    }

                    this.Hide();
                    break;
                }
            }

            if (!kullanicibul)
            {
                MessageBox.Show("Eposta adresi veya şifrenizi hatalı girdiniz.");
            }
        }

        private void frm_KullanıcıGirisEkranı_Load(object sender, EventArgs e)
        {
            cbSifreGoster.CheckState = CheckState.Unchecked;
            txtSifre.UseSystemPasswordChar = true;

        }

        private void cbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreGoster.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = true;
                cbSifreGoster.Text = "Şifre Göster.";
            }
            else if (cbSifreGoster.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
                cbSifreGoster.Text = "Şifre Gizle.";
            }

        }

        private void linklSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
