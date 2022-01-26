namespace ProiectDAW.Models
{
    public class Departamente
    {
        public int IdDepartament { get; set; }
        public string NumeDepartament { get; set; }
        public int IdAngajat { get; set; }
        public virtual angajati angajati { get; set; }
    }
}
