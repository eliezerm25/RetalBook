using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Dto;
using DataModel.Entities;
using DataModel.Migrations;
namespace Business.Mapper
{
    public class Mapper:Profile
    {
      public Mapper() 
      {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
