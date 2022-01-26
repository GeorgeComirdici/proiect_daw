using System.Collections.Generic;
namespace ProiectDAW.Models
{
    public class angajati
    {
        public int IdAngajat { get; set; }
        public string Nume { get; set; }
        public int Salariu { get; set; }
        public virtual AdreseAngajati Adresa { get; set; }
        public virtual ICollection<Departamente> Departament { get; set; }
        public virtual ICollection<Proiecte> Proiect { get; set; }
    }
}
