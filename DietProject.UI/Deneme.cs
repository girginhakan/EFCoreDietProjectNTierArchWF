using DietProject.BLL.Manager.Concrete;
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
    public partial class Deneme : Form
    {
        public Deneme()
        {
            InitializeComponent();
            KullaniciOgunYemekPorsiyonManager manager = new KullaniciOgunYemekPorsiyonManager();

            dataGridView1.DataSource = manager.GetAllWithIncludes();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }
    }
}
