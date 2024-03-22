using AutoMapper;
using DietProject.BLL.Models;
using DietProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.MappingProfile
{
    public class KullaniciDetayMapProfile : Profile
    {
        public KullaniciDetayMapProfile()
        {
            CreateMap<KullaniciModel, Kullanici>().
      ForMember(y => y.KullaniciDetay, b => b.MapFrom(src => src.KullaniciDetay)).ReverseMap();

        }
    }
}
