
using Entity;
using FilmSite.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSite.BLL
{
   public class FilmListeleController
    {
        FilmListeleManagement fm;
        public FilmListeleController()
        {
            fm = new FilmListeleManagement();
        }
       public ICollection<Film> VeriGetir()
        {
            return fm.GetAll();
        }
       public Film VeriGetir(int key)
       {
           return fm.Get(key);
       }
    }
}
