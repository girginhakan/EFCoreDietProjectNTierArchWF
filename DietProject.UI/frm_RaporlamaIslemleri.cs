using DietProject.BLL.Manager.Concrete;
using DietProject.BLL.Models;
using DietProject.DAL.Entities;
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
    public partial class frm_RaporlamaIslemleri : Form
    {
        KategoriManager kategoriManager = new KategoriManager();
        KullaniciManager kullaniciManager = new KullaniciManager();
        KullaniciOgunYemekPorsiyonManager kullaniciOgunYemekPorsiyonManager = new KullaniciOgunYemekPorsiyonManager();
        OgunManager ogunManager = new OgunManager();
        PorsiyonManager porsiyonManager = new PorsiyonManager();
        YemekManager yemekManager = new YemekManager();

        KategoriModel kategoriModel = new KategoriModel();
        KullaniciModel kullaniciModel = new KullaniciModel();
        KullaniciOgunYemekPorsiyonModel kullaniciOgunYemekPorsiyonModel = new KullaniciOgunYemekPorsiyonModel();
        OgunModel ogunModel = new OgunModel();
        PorsiyonModel porsiyonModel = new PorsiyonModel();
        YemekModel yemekModel = new YemekModel();

        public frm_RaporlamaIslemleri()
        {
            InitializeComponent();
            dgvRapor();
        }

        private void dgvRapor()
        {
            var yemekListesi = yemekManager.GetAll();

            var EnCokTuketilen = yemekListesi.GroupBy(y => y.YemekAdi).Select(g => new { YemekAdi = g.Key, ToplamTuketim = g.Count() }).OrderByDescending(g => g.ToplamTuketim).FirstOrDefault();

            dataGridView2.DataSource = EnCokTuketilen;

        }
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_AdminAnaEkrani adminAnaEkrani = new frm_AdminAnaEkrani();
            adminAnaEkrani.Show();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_RaporlamaIslemleri_Load(object sender, EventArgs e)
        {
            dgvRapor();
        }
    }
}
