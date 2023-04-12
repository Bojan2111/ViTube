using System.Globalization;

namespace ViTube.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string VideoUrl { get; set; }
        public string ThumbnaillUrl { get; set; }
        public string Opis { get; set; }
        public string Vidljivost { get; set; }
        public bool DozvoljeniKomentari { get; set; }
        public bool VidljivostRejtinga { get; set; }
        public bool Blokiran { get; set; }
        public int BrojPregleda { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public int KorisnikId { get; set; }
    }
}
