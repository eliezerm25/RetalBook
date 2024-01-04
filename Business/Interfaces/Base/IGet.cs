using Business.Dto.Base;
using DataModel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Base
{
    public interface IGet<T> where T : class 
    {


        public List<T> Get()
        {
            return new List<T>();
        }


        public T? Get(int id);


    }
}
