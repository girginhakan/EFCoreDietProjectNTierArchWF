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
    public class OgunMapProfile : Profile
    {
        public OgunMapProfile()
        {
            CreateMap<KullaniciOgunYemekPorsiyonModel, KullaniciOgunYemekPorsiyon>().
           ForMember(y => y.Ogun, b => b.MapFrom(src => src.Ogun)).ReverseMap();

           
        }
    }
}
