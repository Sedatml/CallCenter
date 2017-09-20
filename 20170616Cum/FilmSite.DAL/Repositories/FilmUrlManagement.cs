using Entity;
using FilmSite.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSite.DAL.Repositories
{
   public class FilmUrlManagement:AbstractManagement,ICrudRepository<FilmUrl,int>
    {

        public string Add(FilmUrl obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(FilmUrl obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<FilmUrl> GetAll()
        {
            return db.Urller.ToList();
        }

        public FilmUrl Get(int id)
        {
            return db.Urller.Find(id);
        }

        public string Update(FilmUrl obj)
        {
            throw new NotImplementedException();
        }
    }
}
