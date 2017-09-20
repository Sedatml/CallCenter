using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Fragman
   {
       public int FragmanID { get; set; }
       public string FragmanUrlAdi { get; set; }
       public ICollection<Film> Filmler { get; set; }
    }
}
