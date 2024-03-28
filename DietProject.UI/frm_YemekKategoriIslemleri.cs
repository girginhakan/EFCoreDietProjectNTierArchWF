using DietProject.BLL.Manager.Concrete;
using DietProject.BLL.Models;
using DietProject.DAL.Context;
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
        KategoriManager kategoriManager = new KategoriManager();
        KategoriModel secilenKategori = new KategoriModel();
        KategoriModel eklenenKategori;
        public frm_YemekKategoriIslemleri()
        {
            InitializeComponent();
            lblSecilen.Text = "Seçilen Kategori: ";
            KategorileriGoster();

        }

        private void KategorileriGoster()
        {
            dgvMevcutYemekKategorileri.DataSource = kategoriManager.GetAll();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text != string.Empty && txtAciklama.Text != string.Empty)
            {
                KategoriModel kategori = new KategoriModel();
                kategori.KategoriAdi = txtKategoriAdi.Text;
                kategori.Aciklama = txtAciklama.Text;
                kategoriManager.Add(kategori);
                dgvMevcutYemekKategorileri.DataSource = kategoriManager.GetAll();
                MessageBox.Show("Kategoriler Eklenmiştir.");
                eklenenKategori = kategori;
                KategorileriGoster();
            }
            else
            {
                MessageBox.Show("Kategori adı ve açıklama boş geçilemez");
                return;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenKategori != null && secilenKategori.KategoriAdi != null && secilenKategori.Aciklama != null)
            {
                kategoriManager.Remove(secilenKategori);

                MessageBox.Show("kategori silinmiştir");
                KategorileriGoster();

                txtKategoriAdi.Text = "";
                txtAciklama.Text = "";

                lblSecilen.Text = "Seçilen kategori: ";
                secilenKategori = null;
                return;

            }
            else
            {
                MessageBox.Show("Silmek için kategori seçiniz!");
                return;
            }

        }

        private void dgvMevcutYemekKategorileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenKategori = (KategoriModel)dgvMevcutYemekKategorileri.SelectedRows[0].DataBoundItem;
            lblSecilen.Text = "Seçilen Kategori: " + secilenKategori.KategoriAdi + " " + secilenKategori.Aciklama;
            txtKategoriAdi.Text = secilenKategori.KategoriAdi;
            txtAciklama.Text = secilenKategori.Aciklama;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
                //kategoriManager.GetById(secilenKategori.Id);
            if (secilenKategori != null && secilenKategori.KategoriAdi != null && secilenKategori.Aciklama != null)
            {
                secilenKategori.KategoriAdi = txtKategoriAdi.Text;
                secilenKategori.Aciklama = txtAciklama.Text;


                kategoriManager.Update(secilenKategori);
                MessageBox.Show("Kategori güncellenmiştir");
                KategorileriGoster();

                txtKategoriAdi.Text = "";
                txtAciklama.Text = "";

                lblSecilen.Text = "Seçilen kategori: ";
                secilenKategori = null;
                return;

            }
            else
            {
                MessageBox.Show("Güncellemek için kategori seçiniz!");
                return;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_AdminAnaEkrani adminAnaEkrani = new frm_AdminAnaEkrani();
            adminAnaEkrani.Show();
            this.Close();
        }
    }
}
