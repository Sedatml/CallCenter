using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Film
    {
       public Film()
       {
            Turs=new HashSet<Tur>();
       }
        public int FilmId { get; set; }
       [Required,MaxLength(100)]
        public string FilmAdi { get; set; }

        public string Konusu { get; set; }
       [Required]
        public DateTime KayitTarihi { get; set; }
       [Required]
        public string Image { get; set; }
        public string Language { get; set; }
        public decimal Suresi { get; set; }
        public decimal Puanı { get; set; }

        public ICollection<Oyuncu> Oyuncus { get; set; }
        public ICollection<AltYazi> AltYazis { get; set; }
        public ICollection<Tur> Turs { get; set; }
        public ICollection<Yonetmen> Yonetmens { get; set; }
        public ICollection<FilmUrl> FilmUrls { get; set; }
        public ICollection<Fragman> Fragmans { get; set; }
    }
}
