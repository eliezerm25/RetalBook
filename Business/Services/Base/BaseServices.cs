using AutoMapper;
using Business.Dto.Base;
using Business.Interfaces.Base;
using Business.Validations.Extension;
using DataModel.Context;
using DataModel.Entities.Base;
using FluentValidation;
using FluentValidation.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace Business.Services.Base
{
    public class BaseServices<T,Dto> : IBaseInterfaces<T> where T : class, IBaseEntity where Dto: BaseDto,new()
    {
        readonly DataContext _context;
        readonly IMapper _mapper;
        public readonly IValidator<T> _validator;
        public BaseServices(DataContext context, IMapper mapper,IValidator<T> validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public void Delete(int id)
        {
            var modelDelete = _context.Set<T>().SingleOrDefault(x => x.Id == id);
            if (modelDelete != null)
            {
               
                _context.Set<T>().Remove(modelDelete);
                _context.SaveChangesAsync();
            }

        }
        public List<Dto> GetDto()=>_mapper.ProjectTo<Dto>(_context.Set<T>()).ToList();
        public List<T> Get()=>_context.Set<T>().ToList();

        public T? Get(int id)
        {
            return _context.Set<T>().FirstOrDefault(c => c.Id == id);
        }

        public List<T> GetIgnoreFilter()
        {
            return _context.Set<T>().IgnoreQueryFilters().ToList();
        }

        public OperationResult<T> Post(T entity)
        {
            var validation = _validator.Validate(entity);
            if (!validation.IsValid)
                return new OperationResult<T>()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = validation.Errors.ToMessage()
                };

            _context.Set<T>().Add(entity);
            _context.SaveChanges();

            return new OperationResult<T>() {Result=entity,StatusCode=HttpStatusCode.OK,Success=true,Message= "Your data was registered correctly" };
        }

        public OperationResult<T> Put(int id, T entity)
        {
           var validation= _validator.Validate(entity);
          
            if (!validation.IsValid)
                return new OperationResult<T>() {
                    StatusCode=HttpStatusCode.BadRequest,
                    Message=validation.Errors.ToMessage()
                };

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return new OperationResult<T>() { Result = entity, StatusCode = HttpStatusCode.OK, Success = true, Message = "Your data was registered correctly" };
        }
    }

}
