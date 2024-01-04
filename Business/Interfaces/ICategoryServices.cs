using Business.Dto;
using Business.Interfaces.Base;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public  interface  ICategoryServices:IBaseInterfaces<Category>
    {

        List<CategoryDto> GetDto();
    }
}
