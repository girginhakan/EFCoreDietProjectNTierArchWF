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
    public partial class Deneme : Form
    {
        public Deneme()
        {
            InitializeComponent();
            KullaniciOgunYemekPorsiyonManager manager = new KullaniciOgunYemekPorsiyonManager();

            dataGridView1.DataSource = manager.GetAllWithIncludes();
            //    dataGridView1.Columns[0].Visible = false;
            //    dataGridView1.Columns[1].Visible = false;
            //    dataGridView1.Columns[2].Visible = false;
            //    dataGridView1.Columns[3].Visible = false;
            //    dataGridView1.Columns[4].Visible = false;


            //admin hashli şifre için adin oluştuma komutu
           KullaniciManager kullaniciManager = new KullaniciManager();
            KullaniciModel model = new KullaniciModel();
            model.Adi = "kerem";
            model.Soyadi = "ozyon";
            model.Boy = 170;
            model.Sifre = Metodlar.Sha256Hash("1234");
            model.UserStatus = UserStatus.Admin;
            model.Eposta = "kerem";
            kullaniciManager.Add(model);
            MessageBox.Show("başarılı");

        }
    }
}
