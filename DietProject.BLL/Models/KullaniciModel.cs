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
        public KullaniciYemekOgunPorsiyonModel KullaniciYemekOgunPorsiyonModel { get; set; }
        public KullaniciDetayModel KullaniciDetayModel { get; set; }
    }
}
