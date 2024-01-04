using DataModel.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Base
{
    public interface IPost<T> where T : class
    {
        public OperationResult<T> Post(T entity);
    }
}
