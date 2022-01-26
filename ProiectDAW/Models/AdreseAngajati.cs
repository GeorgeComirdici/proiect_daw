using System.ComponentModel.DataAnnotations;
namespace ProiectDAW.Models
{
    public class AdreseAngajati
    {
        [Key]
        public int IdAdresa { get; set; }
        public string Adresa { get; set; }
        public string Oras { get; set; }
        public string Tara { get; set; }
        public int IdAngajat { get; set; }

        public virtual angajati angajati { get; set; }
    }
}
