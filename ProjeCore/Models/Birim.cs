using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjeCore.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        public string BirimAd { get; set; }
        public IList<Personel> Personels { get; set; } // interface list formatında, ilişkiyi bu alanda alacağız.
    }
}
