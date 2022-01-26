using System.Collections.Generic;
namespace ProiectDAW.Models
{
    public class Proiecte
    {
        public int IdProiect { get; set; }
        public string DetaliiProiect { get; set; }
        public virtual ICollection<angajati> angajat { get; set; }
    }
}
