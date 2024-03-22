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
        public int KullaniciDetayId { get; set; }
        public List<KullaniciOgunYemekPorsiyonModel> KullaniciOgunYemekPorsiyonlar { get; set; }
        public KullaniciDetayModel KullaniciDetay { get; set; }
        public UserStatus UserStatus { get; set; } = UserStatus.NormalKullanici;

        public override string ToString()
        {
            return KullaniciDetay.Adi + " " + KullaniciDetay.Soyadi;
        }


    }
    public enum UserStatus
    {
        NormalKullanici = 1,
        Admin = 2
    }

}
