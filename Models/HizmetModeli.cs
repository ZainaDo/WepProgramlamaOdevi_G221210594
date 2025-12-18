namespace WebProjesi.Models
{
    public class HizmetModeli //CRUD kullandik
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public int Sure { get; set; } // dakika
        public decimal Fiyat { get; set; }
        public string Saat { get; set; }
        public string Resim { get; set; }
    }
}
