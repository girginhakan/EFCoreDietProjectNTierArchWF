using DietProject.BLL.Manager.Concrete;
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
    public partial class frm_NormalKullaniciAnaEkrani : Form
    {
        //public KullaniciModel SecilenKullanici {  get; set; } 
        //public frm_KullaniciGirisEkrani MainForm { get; set; }

        KullaniciOgunYemekPorsiyonModel seciliTuketikenYemek;
        frm_NormalKullaniciOgunEkleme secilenOgun;
        KullaniciOgunYemekPorsiyonManager kullaniciYemekleri = new KullaniciOgunYemekPorsiyonManager();
        public frm_NormalKullaniciAnaEkrani()
        {
            InitializeComponent();
            
            dgvTuketilenOgunler.DataSource=kullaniciYemekleri.GetAllWithIncludes();
        }



        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            frm_NormalKullaniciOgunEkleme normalKullanıcıOgunEkleme = new frm_NormalKullaniciOgunEkleme();
            normalKullanıcıOgunEkleme.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_AnaGirisEkrani anaGirisEkrani = new frm_AnaGirisEkrani();
            this.Close();
            anaGirisEkrani.Show();
        }

        private void btnOgunGuncelle_Click(object sender, EventArgs e)
        {
            frm_NormalKullaniciOgunEkleme normalKullanıcıOgunEkleme = new frm_NormalKullaniciOgunEkleme();
            normalKullanıcıOgunEkleme.GelenOgun = seciliTuketikenYemek;
            normalKullanıcıOgunEkleme.Show();
            this.Hide();
        }

        private void dgvTuketilenOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliTuketikenYemek = (KullaniciOgunYemekPorsiyonModel)dgvTuketilenOgunler.SelectedRows[0].DataBoundItem;
        }
    }
}
