using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSite.DAL.IRepositories
{
    interface IUpdate<T> where T:class
    {
        string Update(T obj);
    }
}
