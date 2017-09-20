using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSite.DAL.IRepositories
{
    interface ICrudRepository<Tvalue,Tkey>:IAdd<Tvalue>,IDelete<Tvalue,Tkey>,IGet<Tvalue,Tkey>,IUpdate<Tvalue> where Tvalue:class
    {

    }
}
