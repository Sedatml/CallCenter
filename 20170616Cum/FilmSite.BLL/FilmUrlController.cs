using Entity;
using FilmSite.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSite.BLL
{
  public class FilmUrlController
    {
      FilmUrlManagement fum = new FilmUrlManagement();
      public ICollection<FilmUrl> VeriGetir()
      {
          return fum.GetAll();
      }
      public FilmUrl VeriGetir(int key)
      {
          return fum.Get(key);
      }
      
    }
}
