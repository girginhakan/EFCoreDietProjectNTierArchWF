using DietProject.BLL.Manager.Concrete;
using DietProject.BLL.Models;
using DietProject.DAL.Context;
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
    public partial class frm_YemekKategoriIslemleri : Form
    {
        DietProjectDbContext db = new DietProjectDbContext();
        KategoriManager kategoriManager = new KategoriManager();
        Kategori secilenKategori;
        public frm_YemekKategoriIslemleri()
        {
            InitializeComponent();
            lblSecilen.Text = "Seçilen Kategori: ";
            KategorileriGoster();

        }

        private void KategorileriGoster()
        {
            dgvMevcutYemekKategorileri.DataSource = db.Kategoriler.ToList();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            KategoriModel kategori = new KategoriModel();

            kategori.KategoriAdi = txtKategoriAdi.Text;
            kategori.Aciklama = txtAciklama.Text;
            kategoriManager.Add(kategori);
            dgvMevcutYemekKategorileri.DataSource = kategoriManager.GetAll();
            db.SaveChanges();
            MessageBox.Show("Kategoriler Eklenmiştir.");
            KategorileriGoster();
        }

        private void btnSil_Click(object sender, EventArgs e) // hata veriyor kontrol edilmeli
        {
            if (secilenKategori != null)
            {
                db.Kategoriler.Remove(secilenKategori);
                db.SaveChanges();

                MessageBox.Show("kategori silinmiştir");
                KategorileriGoster();

                txtKategoriAdi.Text = "";
                txtAciklama.Text = "";

                secilenKategori = null;
                lblSecilen.Text = "Seçilen kategori: ";

            }
            else
                MessageBox.Show("Silmek için kategori seçiniz!");
        }

        private void dgvMevcutYemekKategorileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenKategori = (Kategori)dgvMevcutYemekKategorileri.SelectedRows[0].DataBoundItem;
            lblSecilen.Text = "Seçilen Kategori: " + secilenKategori.KategoriAdi + " " + secilenKategori.Aciklama;
            txtKategoriAdi.Text = secilenKategori.KategoriAdi;
            txtAciklama.Text = secilenKategori.Aciklama;

        }

        private void btnGuncelle_Click(object sender, EventArgs e) //hata veriyor kontrol edilmeli.
        {
            if (secilenKategori != null)
            {
                secilenKategori.KategoriAdi = txtKategoriAdi.Text;
                secilenKategori.Aciklama = txtAciklama.Text;

                db.SaveChanges();

                MessageBox.Show("Kategori güncellenmiştir");
                KategorileriGoster();

                txtKategoriAdi.Text = "";
                txtAciklama.Text = "";

                secilenKategori = null;
                lblSecilen.Text = "Seçilen kategori: ";

            }
            else
                MessageBox.Show("Güncellemek için kategori seçiniz!");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_AdminAnaEkrani adminAnaEkrani = new frm_AdminAnaEkrani();
            adminAnaEkrani.Show();
            this.Close();
        }
    }
}
