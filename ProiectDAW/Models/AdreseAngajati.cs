namespace ProiectDAW.Models
{
    public class AdreseAngajati
    {
        public string Adresa { get; set; }
        public string Oras { get; set; }
        public string Tara { get; set; }
        public int IdAngajat { get; set; }

        public virtual angajati angajat { get; set; }
    }
}
