using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace ProiectDAW.Models
{
    public class Proiecte
    {
        [Key]
        public int IdProiect { get; set; }
        public string DetaliiProiect { get; set; }
        public virtual ICollection<ProiecteAngajati> ProiecteAngajati { get; set; }
    }
}
