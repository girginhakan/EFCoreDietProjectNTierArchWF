using DietProject.BLL.Models;
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
    public partial class frm_AdminAnaEkrani : Form
    {
        //private KullaniciModel _kullanici;

        public frm_AdminAnaEkrani()
        {
            InitializeComponent();

        }

        public frm_AdminAnaEkrani(KullaniciModel kullanici)
        {
            // _kullanici = kullanici;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnYemekKategoriCRUD_Click(object sender, EventArgs e)
        {
            frm_YemekKategoriIslemleri yemekKategoriIslemleri = new frm_YemekKategoriIslemleri();
            yemekKategoriIslemleri.Show();
            this.Hide();

        }

        private void btnYemekCesidiCRUD_Click(object sender, EventArgs e)
        {
            frm_YemekCesitIslemleri yemekCesitIslemleri = new frm_YemekCesitIslemleri();
            yemekCesitIslemleri.Show();
            this.Hide();
        }

        private void btnOgunİslemleriCRUD_Click(object sender, EventArgs e)
        {
            frm_OgunIslemleri ogunIslemleri = new frm_OgunIslemleri();
            ogunIslemleri.Show();
            this.Hide();
        }

        private void btnPorsiyonİslemleriCRUD_Click(object sender, EventArgs e)
        {
            frm_PorsiyonIslemleri porsiyonIslemleri = new frm_PorsiyonIslemleri();
            porsiyonIslemleri.Show();
            this.Hide();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            s raporlamaIslemleri = new s();
            raporlamaIslemleri.Show();
            this.Hide();
        }

        private void frm_AdminAnaEkrani_Load(object sender, EventArgs e)
        {
            //lblKullanici.Text = _kullanici.Adi;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkış yapmak  istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                frm_AnaGirisEkrani anaGirisEkrani = new frm_AnaGirisEkrani();
                this.Close();
                anaGirisEkrani.Show();
            }


           
        }
    }
}
