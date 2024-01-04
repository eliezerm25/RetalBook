using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Validations.Base;
using DataModel.Context;
using DataModel.Entities;
using FluentValidation;
namespace Business.Validations
{
    public class CategoryValidator : BaseValidator<Category>
    {

        public CategoryValidator(DataContext text) : base(text) {
            RuleFor(x => x.Description).NotEmpty().WithMessage("dasda");
            RuleFor(x => x.Description).Must(Isexist).WithMessage("This category exists");
        }
        public bool Isexist(Category model, string Description)=>
            !_context.Category.Any(x=>!x.Equals(model) &&x.Description==Description);
        
    }
}
