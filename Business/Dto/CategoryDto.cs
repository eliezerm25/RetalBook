using Business.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto
{
    public class CategoryDto:BaseDto
    {
       public CategoryDto()
        {
            Description = string.Empty;
        }
        public string Description { get; set; }
    }
}
