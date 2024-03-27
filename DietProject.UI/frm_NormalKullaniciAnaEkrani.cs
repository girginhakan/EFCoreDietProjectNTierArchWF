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
            
            List<KullaniciOgunYemekPorsiyonModel> model =  kullaniciYemekleri.GetAllWithIncludes().Where(ky => ky.KullaniciId == Program.KullaniciModel.Id).ToList();

            List<TuketilenOgunlerViewModel> viewModel = new List<TuketilenOgunlerViewModel>();

            foreach (var item in model)
            {
                TuketilenOgunlerViewModel row = new TuketilenOgunlerViewModel();
                row.KullaniciAdiSoyadi = item.Kullanici.Adi + " " + item.Kullanici.Soyadi;
                row.PorsiyonMiktari = item.Yemek.PorsiyonMiktari.ToString();
                row.PorsiyonBirimi = item.Porsiyon.PorsiyonBirim;

                viewModel.Add(row);
            }
            dgvTuketilenOgunler.DataSource = viewModel;



            double totalKalori;
            if (seciliTuketikenYemek!=null)
            {
                 totalKalori = double.Parse(seciliTuketikenYemek.Yemek.Kalori.ToString()) * double.Parse(seciliTuketikenYemek.Yemek.PorsiyonMiktari.ToString());
                label3.Text = totalKalori.ToString();
            }
            else
            {
                totalKalori = 0;
                label3.Text = totalKalori.ToString();
            }
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
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
            //normalKullanıcıOgunEkleme.GelenOgun = seciliTuketikenYemek;
            Program.SecilenYemek = seciliTuketikenYemek;
            normalKullanıcıOgunEkleme.Show();
            this.Hide();
        }

        private void dgvTuketilenOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (seciliTuketikenYemek!=null)
            {
                seciliTuketikenYemek = (KullaniciOgunYemekPorsiyonModel)dgvTuketilenOgunler.SelectedRows[0].DataBoundItem;
            }
        }
    }

    public class TuketilenOgunlerViewModel
    {
        public string KullaniciAdiSoyadi { get; set; }
        public string OgunAdi { get; set; }
        public string PorsiyonBirimi { get; set; }
        public string PorsiyonMiktari { get; set; }
        public string YemekAdi { get; set; }
    }
}
