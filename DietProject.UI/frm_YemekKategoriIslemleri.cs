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
    public partial class frm_YemekKategoriIslemleri : Form
    {
        KategoriManager kategoriManager = new KategoriManager();
        KategoriModel kategoriModel = new KategoriModel();
        KategoriModel secilenKategori;
        public frm_YemekKategoriIslemleri()
        {
            InitializeComponent();
            KategoriGoster();

        }

        private void KategoriGoster()
        {

            dgvMevcutYemekKategorileri.DataSource = kategoriManager.GetAllWithIncludes();
            dgvMevcutYemekKategorileri.Columns[0].Visible = true;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kategoriModel.KategoriAdi = txtKategoriAdı.Text;
            kategoriModel.Aciklama = txtAcıklama.Text;
            kategoriManager.Add(kategoriModel);
            txtKategoriAdı.Text = null;
            txtAcıklama.Text = null;
            KategoriGoster();
        }

        private void btnSil_Click(object sender, EventArgs e) // hata veriyor kontrol edilmeli
        {
            if (secilenKategori != null)
            {
                kategoriManager.Delete(secilenKategori);
                MessageBox.Show("Kategori silinmiştir.");
                KategoriGoster();
                txtAcıklama.Text = null;
                txtKategoriAdı.Text = null;
                secilenKategori = null;
            }
            else
                MessageBox.Show("Silmek için kategori seçiniz!");
        }

        private void dgvMevcutYemekKategorileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenKategori = (KategoriModel)dgvMevcutYemekKategorileri.SelectedRows[0].DataBoundItem;
            txtKategoriAdı.Text = secilenKategori.KategoriAdi;
            txtAcıklama.Text = secilenKategori.Aciklama;

        }

        private void btnGuncelle_Click(object sender, EventArgs e) //hata veriyor kontrol edilmeli.
        {
            if (secilenKategori != null)
            {
                secilenKategori.KategoriAdi = txtKategoriAdı.Text;
                secilenKategori.Aciklama = txtAcıklama.Text;
                kategoriManager.Update(secilenKategori);
                MessageBox.Show("Kategori güncellenmiştir");
                KategoriGoster();
                txtAcıklama.Text = null;
                txtKategoriAdı.Text = null;
                secilenKategori = null;
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
