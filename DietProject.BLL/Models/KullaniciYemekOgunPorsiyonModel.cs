using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Models
{
    public class KullaniciYemekOgunPorsiyonModel
    {
        public int Id { get; set; }
        public int YemekId { get; set; }
        public int KullaniciId { get; set; }
        public int OgunId { get; set; }
        public int PorsiyonId { get; set; }
        public List<YemekModel> YemekModel { get; set; }
        public List<OgunModel> OgunModel { get; set; }
        public List<KullaniciModel> KullaniciModel { get; set; }
        public List<PorsiyonModel> PorsiyonModel { get; set; }
    }
}
