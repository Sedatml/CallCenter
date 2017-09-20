using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class FilmUrl
    {
        public int FilmUrlId  { get; set; }
        public string FilmUrlAdi { get; set; }
        public Film Films { get; set; }
    }
}
