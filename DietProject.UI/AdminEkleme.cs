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
    public partial class AdminEkleme : Form
    {
        public AdminEkleme()
        {
            InitializeComponent();
            

            //admin hashli şifre için adin oluştuma komutu Program.csden bu formu başlatıp çalıştırdıktan sonra bu kullanıcı ile admin girişi yapabilirsiniz.
            KullaniciManager kullaniciManager = new KullaniciManager();
            KullaniciModel model = new KullaniciModel();
            model.Adi = "kullaniciAdi";
            model.Soyadi = "kullaniciSoyadi";
            model.Boy = 170;
            model.Sifre = Metodlar.Sha256Hash("1234");
            model.UserStatus = UserStatus.Admin;
            model.Eposta = "kullanici";
            kullaniciManager.Add(model);
            MessageBox.Show("başarılı");

        }
    }
}
