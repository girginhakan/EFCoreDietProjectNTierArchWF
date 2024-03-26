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
    public partial class frm_NormalKullaniciOgunEkleme : Form
    {
        public KullaniciOgunYemekPorsiyonModel GelenOgun {  get; set; }
        OgunManager ogunManager = new OgunManager();
        PorsiyonManager porsiyonManager= new PorsiyonManager();
        YemekManager yemekManager = new YemekManager();
        public frm_NormalKullaniciOgunEkleme()
        {
            InitializeComponent();

            var seciliYemekGuncelle = Program.SecilenYemek;

            if (seciliYemekGuncelle != null)
            {
                cbOgun.SelectedValue = seciliYemekGuncelle.Ogun.OgunAdi;
                cbPorsiyonBirimi.SelectedValue = seciliYemekGuncelle.Porsiyon.PorsiyonBirim;
                cbPorsiyonMiktari.SelectedValue = seciliYemekGuncelle.Porsiyon.PorsiyonMiktari;
                cbYemekCesidi.SelectedValue = seciliYemekGuncelle.Yemek.YemekAdi;
                cbYemekKategori.SelectedValue = seciliYemekGuncelle.Yemek.Kategori.KategoriAdi;
            }
            //else
            //{
            //    foreach (var item in ogunManager.GetAll())
            //    {
            //        cbOgun.Items.Add(item.OgunAdi);
            //    }
            //    foreach (var item in porsiyonManager.GetAll())
            //    {
            //        cbPorsiyonBirimi.Items.Add(item.PorsiyonBirim);
            //        cbPorsiyonMiktari.Items.Add(item.PorsiyonMiktari);
            //    }
            //    foreach (var item in yemekManager.GetAll())
            //    {
            //        cbYemekCesidi.Items.Add(item.YemekAdi);
            //        cbYemekKategori.Items.Add(item.Kategori.KategoriAdi);
            //    }

            //}

        }


        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnKullaniciKayitİptal_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_NormalKullaniciAnaEkrani normalKullaniciAnaEkrani = new frm_NormalKullaniciAnaEkrani();
            normalKullaniciAnaEkrani.Show();
            
        }
    }
}
