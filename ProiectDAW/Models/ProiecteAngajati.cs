namespace ProiectDAW.Models
{
    public class ProiecteAngajati
    {
        public int IdProiect { get; set; }
        public Proiecte Proiecte { get; set; }
        public int IdAngajat { get; set; }
        public angajati angajati { get; set; }
    }
}
