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
    public partial class NormalKullanıcıAnaEkranı : Form
    {
        public NormalKullanıcıAnaEkranı()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            NormalKullanıcıOgunEkleme normalKullanıcıOgunEkleme = new NormalKullanıcıOgunEkleme();
            normalKullanıcıOgunEkleme.Show();
            this.Hide();
        }
    }
}
