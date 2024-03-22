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
    public partial class AdminAnaEkranı : Form
    {
        public AdminAnaEkranı()
        {
            InitializeComponent();
        }

        private void btnYemekKategoriCRUD_Click(object sender, EventArgs e)
        {
            YemekKategoriIslemleri yemekKategoriIslemleri = new YemekKategoriIslemleri();
            yemekKategoriIslemleri.ShowDialog();
            this.Hide();

        }

        private void btnYemekCesidiCRUD_Click(object sender, EventArgs e)
        {
            YemekCesitIslemleri yemekCesitIslemleri = new YemekCesitIslemleri();
            yemekCesitIslemleri.ShowDialog();
            this.Hide();
        }

        private void btnOgunİslemleriCRUD_Click(object sender, EventArgs e)
        {
            OgunIslemleri ogunIslemleri = new OgunIslemleri();
            ogunIslemleri.ShowDialog();
            this.Hide();
        }

        private void btnPorsiyonİslemleriCRUD_Click(object sender, EventArgs e)
        {
            PorsiyonIslemleri porsiyonIslemleri = new PorsiyonIslemleri();
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
