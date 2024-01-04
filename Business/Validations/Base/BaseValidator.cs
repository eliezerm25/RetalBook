using DataModel.Context;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations.Base
{
    public class BaseValidator <T>: AbstractValidator<T> where T : class
    {
        public readonly DataContext _context;
        public BaseValidator(DataContext context) => _context=context ;

        public BaseValidator() { }
    }
}
