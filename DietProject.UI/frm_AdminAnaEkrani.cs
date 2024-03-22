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
    public partial class frm_AdminAnaEkrani : Form
    {
        public frm_AdminAnaEkrani()
        {
            InitializeComponent();
        }

        private void btnYemekKategoriCRUD_Click(object sender, EventArgs e)
        {
            frm_YemekKategoriIslemleri yemekKategoriIslemleri = new frm_YemekKategoriIslemleri();
            yemekKategoriIslemleri.ShowDialog();
            this.Hide();

        }

        private void btnYemekCesidiCRUD_Click(object sender, EventArgs e)
        {
            frm_YemekCesitIslemleri yemekCesitIslemleri = new frm_YemekCesitIslemleri();
            yemekCesitIslemleri.ShowDialog();
            this.Hide();
        }

        private void btnOgunİslemleriCRUD_Click(object sender, EventArgs e)
        {
            frm_OgunIslemleri ogunIslemleri = new frm_OgunIslemleri();
            ogunIslemleri.ShowDialog();
            this.Hide();
        }

        private void btnPorsiyonİslemleriCRUD_Click(object sender, EventArgs e)
        {
            frm_PorsiyonIslemleri porsiyonIslemleri = new frm_PorsiyonIslemleri();
            porsiyonIslemleri.ShowDialog();
            this.Hide();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            s raporlamaIslemleri = new s();
            raporlamaIslemleri.ShowDialog();
            this.Hide();    
        }
    }
}
