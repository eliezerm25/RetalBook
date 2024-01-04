using AutoMapper;
using Business.Dto;
using Business.Interfaces;
using Business.Services.Base;
using DataModel.Context;
using DataModel.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CategoryServices : BaseServices<Category,CategoryDto>, ICategoryServices
    {
        public CategoryServices(DataContext context,IMapper mapper,IValidator<Category>validator) : base(context,mapper,validator)
        {

        }

    }
}
