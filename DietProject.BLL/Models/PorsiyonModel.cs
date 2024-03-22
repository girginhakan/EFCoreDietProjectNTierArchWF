using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Models
{
    public class PorsiyonModel
    {
        public int Id { get; set; }
        public string PorsiyonBirim { get; set; }
        public double PorsiyonMiktari { get; set; }
        public List<KullaniciOgunYemekPorsiyonModel> KullaniciOgunYemekPorsiyonlar { get; set; }
    }
}
