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
        Porsiyon secilenPorsiyon;
        public frm_PorsiyonIslemleri()
        {
            InitializeComponent();
            lblSecilen1.Text = "Seçilen porsiyon bilgileri ";
            PorsiyonGoster();
        }

        private void PorsiyonGoster()
        {
            dgvMevcutPorsiyonlar.DataSource = db.Porsiyonlar.ToList();
        }

        private void btnPorsiyonEkle_Click(object sender, EventArgs e)
        {
            PorsiyonModel porsiyon = new PorsiyonModel();
            porsiyon.PorsiyonMiktari = int.Parse(txtPorsiyonMiktari.Text);
            porsiyon.PorsiyonBirim = txtPorsiyonBirim.Text;
            porsiyonManager.Add(porsiyon);
            dgvMevcutPorsiyonlar.DataSource = porsiyonManager.GetAll();
            db.SaveChanges();
            MessageBox.Show("Porsiyon Bilgileri Eklenmiştir.");
            PorsiyonGoster();
        }
        private void dgvMevcutPorsiyonMiktarları_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenPorsiyon = (Porsiyon)dgvMevcutPorsiyonlar.SelectedRows[0].DataBoundItem;
            lblSecilen1.Text = "Seçilen Porsiyon: " + secilenPorsiyon.PorsiyonMiktari + " " + secilenPorsiyon.PorsiyonBirim;
            txtPorsiyonMiktari.Text = secilenPorsiyon.PorsiyonMiktari.ToString();
            txtPorsiyonBirim.Text = secilenPorsiyon.PorsiyonBirim;
        }
        private void btnPorsiyonGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenPorsiyon != null)
            {
                secilenPorsiyon.PorsiyonMiktari = int.Parse(txtPorsiyonMiktari.Text);
                secilenPorsiyon.PorsiyonBirim = txtPorsiyonBirim.Text;

                db.SaveChanges();

                MessageBox.Show("Porsiyon güncellenmiştir");
                PorsiyonGoster();

                txtPorsiyonMiktari.Text = "";
                txtPorsiyonBirim.Text = "";

                secilenPorsiyon = null;
                lblSecilen1.Text = "Seçilen porsiyon: ";

            }
            else
                MessageBox.Show("Güncellemek için porsiyon seçiniz!");
        }



        private void btnPorsiyonSil_Click(object sender, EventArgs e)
        {
            if (secilenPorsiyon != null)
            {
                db.Porsiyonlar.Remove(secilenPorsiyon);
                db.SaveChanges();

                MessageBox.Show("Porsiyon silinmiştir");
                PorsiyonGoster();

                txtPorsiyonMiktari.Text = "";
                txtPorsiyonBirim.Text = "";

                secilenPorsiyon = null;
                lblSecilen1.Text = "Seçilen porsiyon: ";

            }
            else
                MessageBox.Show("Silmek için porsiyon seçiniz!");
        }

    }
}
