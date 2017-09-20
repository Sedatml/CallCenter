using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class AltYazi
   {
       public AltYazi()
       {
           Filmler = new HashSet<Film>();
       }
       public int AltYaziID { get; set; }

       public string AltyaziDili { get; set; }
      
       public ICollection<Film> Filmler { get; set; }
    }
}
