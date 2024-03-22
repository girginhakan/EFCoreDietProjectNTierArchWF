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
    public class KullaniciOgunYemekPorsiyonMapProfile : Profile
    {
        public KullaniciOgunYemekPorsiyonMapProfile()
        {
            CreateMap<KullaniciModel, Kullanici>().
           ForMember(y => y.KullaniciOgunYemekPorsiyonlar, b => b.MapFrom(src => src.KullaniciOgunYemekPorsiyonlar)).ReverseMap();

            CreateMap<OgunModel, Ogun>().
           ForMember(y => y.KullaniciOgunYemekPorsiyonlar, b => b.MapFrom(src => src.KullaniciOgunYemekPorsiyonlar)).ReverseMap();

            CreateMap<YemekModel, Yemek>().
             ForMember(y => y.KullaniciOgunYemekPorsiyonlar, b => b.MapFrom(src => src.KullaniciOgunYemekPorsiyonlar)).ReverseMap();

            CreateMap<PorsiyonModel, Porsiyon>().
           ForMember(y => y.KullaniciOgunYemekPorsiyonlar, b => b.MapFrom(src => src.KullaniciOgunYemekPorsiyonlar)).ReverseMap();




        }
    }
}
