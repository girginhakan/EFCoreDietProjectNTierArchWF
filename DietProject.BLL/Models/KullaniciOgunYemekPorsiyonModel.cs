
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
        public KullaniciModel KullaniciModel { get; set; }
        public OgunModel OgunModel { get; set; }
        public PorsiyonModel PorsiyonModel { get; set; }
        public YemekModel YemekModel { get; set; }
    }
}
