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
    public partial class frm_NormalKullanıcıOgunEkleme : Form
    {
        public frm_NormalKullanıcıOgunEkleme()
        {
            InitializeComponent();
        }

        private void btnKullaniciKayitİptal_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
