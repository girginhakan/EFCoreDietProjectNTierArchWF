using DietProject.BLL.Manager.Concrete;
using DietProject.BLL.Models;
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
    public partial class frm_OgunIslemleri : Form
    {
        public frm_OgunIslemleri()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OgunManager ogunManager = new OgunManager();
            OgunModel ogunModel = new OgunModel();
            ogunModel.OgunAdi = txtOgunEkle.Text;
            ogunModel.Aciklama = " dsajasdasdsadsad";
            ogunManager.Add(ogunModel);
        }
    }
}
