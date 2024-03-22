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
    public class PorsiyonMapProfile : Profile
    {
        public PorsiyonMapProfile()
        {
            CreateMap<KullaniciOgunYemekPorsiyonModel, KullaniciOgunYemekPorsiyon>().
                ForMember(y => y.Porsiyon, k => k.MapFrom(src => src.Porsiyon)).ReverseMap();
        }
    }
}
