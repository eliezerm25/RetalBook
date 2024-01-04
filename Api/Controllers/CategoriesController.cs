using Api.Controllers.Base;
using Business.Dto;
using Business.Interfaces;
using Business.Services;
using DataModel.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : BaseController<Category>
    {

        readonly ICategoryServices _service;
        public CategoriesController(ICategoryServices services):base(services) {  
        _service = services;
        }

        //[HttpGet]

        //public IActionResult Get()
        //{
        //    return Ok(_service.GetDto());
        //}

        [HttpGet("GetIgnore")]

        public IActionResult GetIgnore()
        {
            return base.Get();
            //return Ok(_service.GetIgnoreFilter());
        }
    }
}
