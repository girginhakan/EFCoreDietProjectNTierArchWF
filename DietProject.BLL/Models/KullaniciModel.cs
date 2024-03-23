using DietProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Models
{
    public class KullaniciModel
    {
        public int Id { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }

        public List<KullaniciOgunYemekPorsiyonModel> KullaniciOgunYemekPorsiyonlar { get; set; }
        public UserStatus UserStatus { get; set; } = UserStatus.NormalKullanici;

    }
    public enum UserStatus
    {
        NormalKullanici = 1,
        Admin = 2
    }

}
