using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Base
{
    public interface IGetIgnoreFilter<T> where T : class
    {
        public List<T> GetIgnoreFilter();

    }
}
