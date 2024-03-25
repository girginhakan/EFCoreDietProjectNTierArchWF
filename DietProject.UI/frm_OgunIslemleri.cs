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
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProject.UI
{
    public partial class frm_OgunIslemleri : Form
    {
        DietProjectDbContext db = new DietProjectDbContext();
        OgunManager ogunManager = new OgunManager();
        Ogun secilenOgun;

        public frm_OgunIslemleri()
        {
            InitializeComponent();
            lblSecilen.Text = "Seçilen Öğün: ";
            OgunleriGoster();
        }

        private void OgunleriGoster()
        {
            dgvMevcutOgunler.DataSource=db.Ogunler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OgunModel ogun = new OgunModel();

            ogun.OgunAdi = txtOgunAdi.Text;
            ogun.Aciklama = txtAciklama.Text;
            ogunManager.Add(ogun);
            dgvMevcutOgunler.DataSource = ogunManager.GetAll();
            db.SaveChanges();
            MessageBox.Show("Öğünler Eklenmiştir.");
            OgunleriGoster();

        }

        private void dgvMevcutOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgun = (Ogun)dgvMevcutOgunler.SelectedRows[0].DataBoundItem;
            lblSecilen.Text = "Seçilen Öğün: " + secilenOgun.OgunAdi + " " + secilenOgun.Aciklama;
            txtOgunAdi.Text = secilenOgun.OgunAdi;
            txtAciklama.Text = secilenOgun.Aciklama;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenOgun != null)
            {
                secilenOgun.OgunAdi = txtOgunAdi.Text;
                secilenOgun.Aciklama = txtAciklama.Text;

                db.SaveChanges();

                MessageBox.Show("Öğün güncellenmiştir");
                OgunleriGoster();

                txtOgunAdi.Text = "";
                txtAciklama.Text = "";

                secilenOgun = null;
                lblSecilen.Text = "Seçilen öğün: ";

            }
            else
                MessageBox.Show("Güncellemek için öğün seçiniz!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenOgun != null)
            {
                db.Ogunler.Remove(secilenOgun);
                db.SaveChanges();

                MessageBox.Show("Öğün silinmiştir");
                OgunleriGoster();

                txtOgunAdi.Text = "";
                txtAciklama.Text = "";

                secilenOgun = null;
                lblSecilen.Text = "Seçilen öğün: ";

            }
            else
                MessageBox.Show("Silmek için öğün seçiniz!");
        }
    }
}
