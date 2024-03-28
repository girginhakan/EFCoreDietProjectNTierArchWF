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

        KullaniciOgunYemekPorsiyonModel secilenTuketikenYemek = new KullaniciOgunYemekPorsiyonModel();
        KullaniciOgunYemekPorsiyonManager kullaniciYemekleri = new KullaniciOgunYemekPorsiyonManager();
        YemekModel yemekKalori = new YemekModel();
        KullaniciManager kullaniciManager = new KullaniciManager();
        YemekManager yemekManager = new YemekManager();
        OgunManager ogunManager = new OgunManager();
        public frm_NormalKullaniciAnaEkrani()
        {
            InitializeComponent();
            YemekListesi();

        }

        private void YemekListesi()
        {
            List<KullaniciOgunYemekPorsiyonModel> model = kullaniciYemekleri.GetAllWithIncludes().Where(ky => ky.KullaniciId == Program.KullaniciModel.Id).ToList();

            List<TuketilenOgunlerViewModel> viewModel = new List<TuketilenOgunlerViewModel>();

            foreach (var item in model)
            {
                TuketilenOgunlerViewModel row = new TuketilenOgunlerViewModel();
                row.KullaniciAdiSoyadi = item.Kullanici.Adi + " " + item.Kullanici.Soyadi;
                row.PorsiyonMiktari = item.PorsiyonMiktari;
                row.PorsiyonBirimi = item.Porsiyon.PorsiyonBirim;
                row.YemekAdi = item.Yemek.YemekAdi;
                row.OgunAdi = item.Ogun.OgunAdi;
                row.Id = item.Id;

                viewModel.Add(row);
            }

            dgvTuketilenOgunler.DataSource = viewModel;
            dgvTuketilenOgunler.Columns[0].Visible = false;
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
            normalKullanıcıOgunEkleme.Show();
            this.Hide();
        }

        private void dgvTuketilenOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvTuketilenOgunler = (DataGridView)sender;

            var seciliTuketikenYemek = (TuketilenOgunlerViewModel)dgvTuketilenOgunler.SelectedRows[0].DataBoundItem;

            secilenTuketikenYemek = kullaniciYemekleri.Search((x => x.Id == seciliTuketikenYemek.Id)).FirstOrDefault();

            Program.kullaniciOgunYemekPorsiyonModel = secilenTuketikenYemek;


        }

        private void frm_NormalKullaniciAnaEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (secilenTuketikenYemek != null)
            {
                kullaniciYemekleri.Remove(secilenTuketikenYemek);

                MessageBox.Show("Öğün silinmiştir.");
                YemekListesi();

            }
            else
                MessageBox.Show("Secili Öğün Yok!");
        }
    }

    public class TuketilenOgunlerViewModel
    {
        public int Id { get; set; }
        public string KullaniciAdiSoyadi { get; set; }
        public string OgunAdi { get; set; }
        public string PorsiyonBirimi { get; set; }
        public double PorsiyonMiktari { get; set; }
        public string YemekAdi { get; set; }
    }

   
}
