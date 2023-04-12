namespace ViTube.Models
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Opis { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Uloga { get; set; }
        public bool Blokiran { get; set; }
        public List<Korisnik> Pratioci { get; set; }
    }
}
