
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Models
{
    public class KullaniciOgunYemekPorsiyonModel
    {
        public int Id { get; set; }
        public int YemekId { get; set; }
        public int KullaniciId { get; set; }
        public int OgunId { get; set; }
        public int PorsiyonId { get; set; }
        public KullaniciModel Kullanici { get; set; }
        public OgunModel Ogun { get; set; }
        public PorsiyonModel Porsiyon { get; set; }
        public YemekModel Yemek { get; set; }
    }
}
