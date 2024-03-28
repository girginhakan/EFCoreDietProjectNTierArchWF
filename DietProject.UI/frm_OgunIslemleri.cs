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
        OgunManager ogunManager = new OgunManager();
        OgunModel secilenOgun = new OgunModel();

        public frm_OgunIslemleri()
        {
            InitializeComponent();
            lblSecilen.Text = "Seçilen Öğün: ";
            OgunleriGoster();
        }

        private void OgunleriGoster()
        {
            dgvMevcutOgunler.DataSource = ogunManager.GetAll();
        }


        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtOgunAdi.Text != string.Empty && txtAciklama.Text != string.Empty)
            {
                OgunModel eklenenOgun= new OgunModel();
                eklenenOgun.OgunAdi = txtOgunAdi.Text;
                eklenenOgun.Aciklama = txtAciklama.Text;
                ogunManager.Add(eklenenOgun);
                dgvMevcutOgunler.DataSource = ogunManager.GetAll();
                MessageBox.Show("Öğünler Eklenmiştir.");
                OgunleriGoster();
            }
            else
            {
                MessageBox.Show("Öğün adı ve açıklama boş geçilemez");
                return;
            }


        }

        private void dgvMevcutOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgun = (OgunModel)dgvMevcutOgunler.SelectedRows[0].DataBoundItem;
            lblSecilen.Text = "Seçilen Öğün: " + secilenOgun.OgunAdi + " " + secilenOgun.Aciklama;
            txtOgunAdi.Text = secilenOgun.OgunAdi;
            txtAciklama.Text = secilenOgun.Aciklama;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenOgun!=null&& secilenOgun.OgunAdi != null && secilenOgun.Aciklama != null)
            {
                secilenOgun.OgunAdi = txtOgunAdi.Text;
                secilenOgun.Aciklama = txtAciklama.Text;
                ogunManager.Update(secilenOgun);
                MessageBox.Show("Öğün güncellenmiştir");
                OgunleriGoster();

                txtOgunAdi.Text = "";
                txtAciklama.Text = "";
                lblSecilen.Text = "Seçilen öğün: ";
            }
            else
            {
                MessageBox.Show("Güncellemek için öğün seçiniz!");
                return;
            }
            secilenOgun = null;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenOgun != null && secilenOgun.OgunAdi != null && secilenOgun.Aciklama != null)
            {
                ogunManager.Remove(secilenOgun);
                MessageBox.Show("Öğün silinmiştir");
                OgunleriGoster();

                txtOgunAdi.Text = "";
                txtAciklama.Text = "";

                //secilenOgun = null;
                lblSecilen.Text = "Seçilen öğün: ";

            }
            else
            {
                MessageBox.Show("Silmek için öğün seçiniz!");
                return;
            }
            secilenOgun = null;

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_AdminAnaEkrani adminAnaEkrani = new frm_AdminAnaEkrani();
            adminAnaEkrani.Show();
        }

        private void frm_OgunIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
