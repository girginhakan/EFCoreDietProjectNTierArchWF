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
    public partial class frm_PorsiyonIslemleri : Form
    {
        DietProjectDbContext db = new DietProjectDbContext();
        PorsiyonManager porsiyonManager = new PorsiyonManager();
        PorsiyonModel seciliPorsiyon = new PorsiyonModel();

        public frm_PorsiyonIslemleri()
        {
            InitializeComponent();
            lblSecilen1.Text = "Seçilen porsiyon bilgileri ";
            PorsiyonGoster();
        }

        private void PorsiyonGoster()
        {
            dgvMevcutPorsiyonlar.DataSource = porsiyonManager.GetAll();
        }


        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnPorsiyonEkle_Click(object sender, EventArgs e)
        {
            if (txtPorsiyonBirim.Text != string.Empty)
            {

                seciliPorsiyon.PorsiyonBirim = txtPorsiyonBirim.Text;
                porsiyonManager.Add(seciliPorsiyon);
                dgvMevcutPorsiyonlar.DataSource = porsiyonManager.GetAll();
                MessageBox.Show("Porsiyon Bilgileri Eklenmiştir.");
                PorsiyonGoster();
            }
            else
            {
                MessageBox.Show("Porsiyon birim ile miktar boş geçilemez");
                return;
            }
            
        }
        private void dgvMevcutPorsiyonMiktarları_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliPorsiyon = (PorsiyonModel)dgvMevcutPorsiyonlar.SelectedRows[0].DataBoundItem;
            lblSecilen1.Text = "Seçilen Porsiyon: "  + seciliPorsiyon.PorsiyonBirim;
            txtPorsiyonBirim.Text = seciliPorsiyon.PorsiyonBirim;
        }
        private void btnPorsiyonGuncelle_Click(object sender, EventArgs e)
        {
            if ( seciliPorsiyon.PorsiyonBirim!= null)
            {
                seciliPorsiyon.PorsiyonBirim = txtPorsiyonBirim.Text;
                porsiyonManager.Update(seciliPorsiyon);

                MessageBox.Show("Porsiyon güncellenmiştir");
                PorsiyonGoster();


                txtPorsiyonBirim.Text = "";

                //seciliPorsiyon = null;
                lblSecilen1.Text = "Seçilen porsiyon: ";

            }
            else
            {
                MessageBox.Show("Güncellemek için porsiyon seçiniz!");
                return;
            }
        }



        private void btnPorsiyonSil_Click(object sender, EventArgs e)
        {
            if (seciliPorsiyon != null &&  seciliPorsiyon.PorsiyonBirim != null)
            {
                porsiyonManager.Remove(seciliPorsiyon);

                MessageBox.Show("Porsiyon silinmiştir");
                PorsiyonGoster();

                
                txtPorsiyonBirim.Text = "";

                //secilenPorsiyon = null;
                lblSecilen1.Text = "Seçilen porsiyon: ";

            }
            else
            {
                MessageBox.Show("Silmek için porsiyon seçiniz!");
                return;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_AdminAnaEkrani adminAnaEkrani = new frm_AdminAnaEkrani();
            adminAnaEkrani.Show();
        }
    }
}
