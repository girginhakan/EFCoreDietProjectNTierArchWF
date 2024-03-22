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
    public partial class frm_KullanıcıGirisEkranı : Form
    {
        public frm_KullanıcıGirisEkranı()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            frm_AnaGirisEkranı anaGirisEkranı = new frm_AnaGirisEkranı();
            this.Close();
            anaGirisEkranı.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string eposta = txtEposta.Text;
            KullaniciModel eslesenKullanici = new KullaniciModel();

            KullaniciManager kullaniciManager = new KullaniciManager();

            foreach (KullaniciModel kullanici in kullaniciManager.GetAllWithIncludes())
            {
                if (kullanici.Eposta == eposta)
                {
                    eslesenKullanici = kullanici;

                }
                else
                {
                    MessageBox.Show("Yanlış eposta adresi girdiniz.");
                }
            }
            string sifre = txtSifre.Text;

            foreach (KullaniciModel kullanici in kullaniciManager.GetAllWithIncludes())
            {
                if (kullanici.Sifre == sifre)
                {
                    eslesenKullanici = kullanici;

                }
                else
                {
                    MessageBox.Show("Yanlış şifre adresi girdiniz.");
                }
            }
            if (eslesenKullanici.UserStatus == UserStatus.NormalKullanici)
            {
                frm_NormalKullanıcıAnaEkranı normalKullanıcıAnaEkranı = new frm_NormalKullanıcıAnaEkranı();
                normalKullanıcıAnaEkranı.ShowDialog();
                this.Hide();
            }
            else if (eslesenKullanici.UserStatus == UserStatus.Admin)
            {
                AdminAnaEkranı adminAnaEkranı = new AdminAnaEkranı();
                adminAnaEkranı.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş işlemi başarısız.");
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
