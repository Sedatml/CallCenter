using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSite.DAL
{
   public class FilmSiteContext:DbContext
    {
       public FilmSiteContext():base("FilmSiteDB")
       {

       }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Yonetmen> Yonetmenler { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<AltYazi> Altyazilar { get; set; }
        public DbSet<FilmUrl> Urller { get; set; }
        public DbSet<Fragman> Fragmanlar { get; set; }
    }
}
