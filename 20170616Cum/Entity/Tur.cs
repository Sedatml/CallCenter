using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Tur
    {
       public Tur()
       {
           Filmler = new HashSet<Film>();
       }
        public int TurId { get; set; }
        public string TurAdi { get; set; }
        public ICollection<Film> Filmler { get; set; }
    }
}
