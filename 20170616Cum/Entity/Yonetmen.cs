using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class Yonetmen
    {
      public Yonetmen()
      {
          Filmler = new HashSet<Film>();
      }

        public int YonetmenId { get; set; }
        public string YonetmenAdi { get; set; }
        public virtual ICollection<Film> Filmler { get; set; }

    }
}
