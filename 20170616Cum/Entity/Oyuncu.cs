using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Oyuncu
    {
       public Oyuncu()
       {
           Filmler = new HashSet<Film>();
       }
       public int OyuncuID { get; set; }
       [Required, MaxLength(50)]
       public string OyuncuAdi { get; set; }
       public ICollection<Film> Filmler { get; set; }
    }
}
