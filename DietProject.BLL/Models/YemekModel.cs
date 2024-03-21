using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Models
{
    public class YemekModel
    {
        public int Id { get; set; }
        public string YemekAdi { get; set; }
        public string? Aciklama { get; set; }
        public double Kalori { get; set; }
        public int KategoriId { get; set; }
        public KategoriModel KategoriModel { get; set; }
        public KullaniciYemekOgunPorsiyonModel KullaniciYemekOgunPorsiyonModel { get; set; }
    }
}
