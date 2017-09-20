using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Mapping
{
   public class FilmMapping:EntityTypeConfiguration<Film>
    {
       public FilmMapping()
       {
           this.ToTable("Filmler");
           HasKey(f=>f.FilmId);

           this.HasMany(f => f.Turs).WithMany(f => f.Filmler).Map(f =>
           {
               f.MapLeftKey("FilmId");
               f.MapRightKey("TurId");
               f.ToTable("TurFilmId");
           });


           this.HasMany(f => f.Oyuncus).WithMany(f => f.Filmler).Map(f =>
           {
               f.MapLeftKey("FilmId");
               f.MapRightKey("OyuncuId");
               f.ToTable("OyuncuFilmId");
           });

           this.HasMany(f => f.Yonetmens).WithMany(f => f.Filmler).Map(f =>
           {
               f.MapLeftKey("FilmId");
               f.MapRightKey("YonetmenId");
               f.ToTable("YonetmenFilmId");
           });
           this.HasMany(f => f.Fragmans).WithMany(f => f.Filmler).Map(f =>
           {
               f.MapLeftKey("FilmId");
               f.MapRightKey("FragmanId");
               f.ToTable("FragmanFilmId");
           });

           this.HasMany(f => f.AltYazis).WithMany(f => f.Filmler).Map(f =>
           {
               f.MapLeftKey("FilmId");
               f.MapRightKey("AltyaziId");
               f.ToTable("AltyaziFilmId");
           });
       }
    }
}
