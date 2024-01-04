using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Base
{
    public interface IDelete<T> where T : class
    {
        void Delete(int id);
    }
}
