namespace ViTube.Models
{
    public class Komentar
    {
        public int Id { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}
