using Business.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Base
{
    public interface IBaseInterfaces<T> : IGet<T>, IPost<T>, IGetIgnoreFilter<T>, IPut<T>, IDelete<T> where T : class
    {
    }
}
