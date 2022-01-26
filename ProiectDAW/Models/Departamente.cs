using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace ProiectDAW.Models
{
    public class Departamente
    {
        [Key]
        public int IdDepartament { get; set; }
        public string NumeDepartament { get; set; }
        public virtual ICollection<angajati> angajatis { get; set; }
    }
}
