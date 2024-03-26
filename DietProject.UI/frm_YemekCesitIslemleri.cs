﻿using DietProject.BLL.Manager.Concrete;
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
        public frm_YemekCesitIslemleri()
        {
            InitializeComponent();
            //KategoriManager kategoriManager = new KategoriManager();
            //dgvMevcutYemekCesitleri.DataSource = kategoriManager.GetAllWithIncludes();
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
    }
}
