using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Models
{
    public class KategoriModel
    {

        // UI ile dal arasındaki geciş objeleri

        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public List<YemekModel> YemekModel { get; set; }

    }
}
