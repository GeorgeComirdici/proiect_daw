using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace ProiectDAW.Models
{
    public class angajati
    {
        [Key]
        public int IdAngajat { get; set; }
        public string Nume { get; set; }
        public int Salariu { get; set; }
        public virtual AdreseAngajati AdreseAngajati { get; set; }
        public virtual ICollection<ProiecteAngajati> ProiecteAngajati { get; set; }
        public int ForeignKeyDepartamente { get; set; }
        public Departamente Departamente { get; set; }
    }
}
