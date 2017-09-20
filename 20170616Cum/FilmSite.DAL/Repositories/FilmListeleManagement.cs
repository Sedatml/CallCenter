using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSite.DAL.IRepositories;
using Entity;
using Extension;
using System.Web;
using System.Web.UI;

namespace FilmSite.DAL.Repositories
{
   public class FilmListeleManagement:AbstractManagement,ICrudRepository<Film,int>
    {

        public string Add(Film obj)
        {
            try
            {
               
                db.Filmler.Add(obj);
                db.SaveChanges();
                string message = "Ekleme Başarılı";
                return Helper.MesajGoster(HttpContext.Current.CurrentHandler as Page, message);
            }
            catch (Exception ex)
            {

                return Helper.MesajGoster(HttpContext.Current.CurrentHandler as Page, ex.Message);
            }
        }

        public string Delete(Film obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Film> GetAll()
        {
            return db.Filmler.ToList();
        }

        public Film Get(int id)
        {
            return db.Filmler.Find(id);
        }

        public string Update(Film obj)
        {
            throw new NotImplementedException();
        }
    }
}
