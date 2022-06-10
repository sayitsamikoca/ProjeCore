using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace ProjeCore.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }

        public int BirimID { get; set; }
        public Birim Birim { get; set; } // Bire çok ilişki için Birim sınfından bir nesne türettim.
    }
}
