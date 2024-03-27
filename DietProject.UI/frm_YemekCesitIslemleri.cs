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
    public partial class frm_YemekCesitIslemleri : Form
    {
        DietProjectDbContext db = new DietProjectDbContext();
        YemekManager yemekManager = new YemekManager();
        YemekModel secilenYemek = new YemekModel();
        KategoriManager kategoriler = new KategoriManager();
        public frm_YemekCesitIslemleri()
        {
            InitializeComponent();
            lblSecilen.Text = "Seçilen Yemekler: ";
            YemekleriGoster();

            cbKategori.DataSource = kategoriler.GetAll();
            cbKategori.DisplayMember = "KategoriAdi";
            cbKategori.ValueMember = "Id";

            //foreach (var item in kategoriler.GetAll())
            //{
            //    cbKategori.Items.Add(item.KategoriAdi);
            //}
        }

        private void YemekleriGoster()
        {
            dgvMevcutYemekCesitleri.DataSource = yemekManager.GetAllWithIncludes();
        }
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_AdminAnaEkrani adminAnaEkrani = new frm_AdminAnaEkrani();
            adminAnaEkrani.Show();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtYemekAdi.Text != string.Empty && txtAciklama.Text != string.Empty && txtKalori.Text != string.Empty && cbKategori.Text != null)
            {
                secilenYemek.Kalori = int.Parse(txtKalori.Text.ToString());

                KategoriModel selectedKategori = (KategoriModel)cbKategori.SelectedItem;

                secilenYemek.YemekAdi = txtYemekAdi.Text;
                secilenYemek.Aciklama = txtAciklama.Text;

                if (selectedKategori != null)
                {

                    secilenYemek.KategoriId = selectedKategori.Id;
                }
                else
                {
                    KategoriModel yeniKategori = new KategoriModel();
                    yeniKategori.KategoriAdi = cbKategori.Text;
                    yeniKategori.Aciklama = "Kullanıcı ekledi";

                    secilenYemek.Kategori = yeniKategori;
                }

                //secilenYemek.Kategori.KategoriAdi = cbKategori.SelectedItem.ToString();

                yemekManager.Add(secilenYemek);
                dgvMevcutYemekCesitleri.DataSource = yemekManager.GetAllWithIncludes();
                MessageBox.Show("Yemekler eklenmiştir.");
                YemekleriGoster();
            }
            else
            {
                MessageBox.Show("Yemek adi, aciklama ve kalori boş geçilemez.");
                return;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenYemek.YemekAdi != null && secilenYemek.Aciklama != null && secilenYemek.Kalori != null && cbKategori.Text != null)
            {

                secilenYemek.YemekAdi = txtYemekAdi.Text;
                secilenYemek.Aciklama = txtAciklama.Text;
                secilenYemek.Kalori = int.Parse(txtKalori.Text.ToString());
                KategoriModel selectedKategori = (KategoriModel)cbKategori.SelectedItem;

                if (selectedKategori != null)
                {

                    secilenYemek.KategoriId = selectedKategori.Id;
                }

                //var x = cbKategori.SelectedItem;
                //secilenYemek.Kategori = new KategoriModel();
                //secilenYemek.Kategori.KategoriAdi = cbKategori.SelectedItem.ToString();

                yemekManager.Update(secilenYemek);
                MessageBox.Show("Yemek güncellenmiştir");
                YemekleriGoster();

                txtYemekAdi.Text = "";
                txtAciklama.Text = "";
                txtKalori.Text = "";

                lblSecilen.Text = "Seçilen yemek: ";

            }
            else
            {
                MessageBox.Show("Güncellemek için yemek seçiniz!");
                return;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenYemek!=null&&secilenYemek.YemekAdi != null && secilenYemek.Aciklama != null && secilenYemek.Kalori != null && cbKategori.Text != null)
            {
                yemekManager.Remove(secilenYemek);

                MessageBox.Show("Yemek silinmiştir");
                YemekleriGoster();

                txtYemekAdi.Text = "";
                txtAciklama.Text = "";
                txtKalori.Text = "";

                lblSecilen.Text = "Seçilen yemek: ";
                

            }
            else
            {
                MessageBox.Show("Silmek için yemek seçiniz!");
                return;
            }
            //secilenYemek = null;
        }

        private void dgvMevcutYemekCesitleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbKategori.SelectedText=string.Empty;
            secilenYemek = (YemekModel)dgvMevcutYemekCesitleri.SelectedRows[0].DataBoundItem;
            lblSecilen.Text = "Seçilen Yemek: " + secilenYemek.YemekAdi + " Açıklama: " + secilenYemek.Aciklama + " Kalor" + secilenYemek.Kalori;

            //secilenYemek.Kalori=int.Parse(txtKalori.Text.ToString()) ;
            txtKalori.Text=secilenYemek.Kalori.ToString();
            txtYemekAdi.Text = secilenYemek.YemekAdi;
            txtAciklama.Text = secilenYemek.Aciklama;
            KategoriModel selectedKategori = (KategoriModel)cbKategori.SelectedItem;
            cbKategori.SelectedText = selectedKategori.ToString();

        }
    }
}
