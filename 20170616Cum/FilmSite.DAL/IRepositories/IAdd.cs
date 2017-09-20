using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSite.DAL.IRepositories
{
    interface IAdd<T> where T:class
    {
      string Add (T obj);
    }
}
