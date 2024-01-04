using AutoMapper;
using Business.Dto.Base;
using Business.Interfaces.Base;
using DataModel.Entities.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace Api.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<T> : ControllerBase
    where T : class, IBaseEntity, new()
    {

        protected readonly IBaseInterfaces<T> _service;

        protected BaseController(IBaseInterfaces<T> service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult Get() => Ok(_service.Get());
        [HttpGet("{id}")]
        public ActionResult Get(int id) => Ok(_service.Get(id));

    }
}
