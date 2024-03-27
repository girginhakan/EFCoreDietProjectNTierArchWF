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
        public int Kalori { get; set; }


        public int KategoriId { get; set; }
        public KategoriModel Kategori { get; set; }
        public List<KullaniciOgunYemekPorsiyonModel> KullaniciOgunYemekPorsiyonlar { get; set; }
    }
}
