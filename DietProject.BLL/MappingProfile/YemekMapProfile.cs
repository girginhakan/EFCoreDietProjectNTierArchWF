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
    public class YemekMapProfile : Profile
    {
        public YemekMapProfile()
        {
            CreateMap<KategoriModel, Kategori>().
            ForMember(y => y.Yemekler, b => b.MapFrom(src => src.YemekModel)).ReverseMap();
        }
    }
}
