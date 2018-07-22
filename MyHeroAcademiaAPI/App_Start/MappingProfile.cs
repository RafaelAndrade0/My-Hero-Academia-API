using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MyHeroAcademiaAPI.Models;
using MyHeroAcademiaAPI.Dto;

namespace MyHeroAcademiaAPI.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Hero, HeroDto>();
            Mapper.CreateMap<HeroDto, Hero>();
        }
    }
}