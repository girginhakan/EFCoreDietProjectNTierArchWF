using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Models
{
    public class OgunModel
    {
        public int Id { get; set; }
        public string OgunAdi { get; set; }
        public string Aciklama { get; set; }
        public List<KullaniciOgunYemekPorsiyonModel> KullaniciOgunYemekPorsiyonlar { get; set; }
    }
}
