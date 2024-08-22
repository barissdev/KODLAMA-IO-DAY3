class Program
{
    static void Main(string[] args)
    {
        MusteriManager musteriManager = new MusteriManager();
        
        // Yeni müşteriler ekleniyor
        Musteri musteri1 = new Musteri(1, "Ahmet", "Yılmaz", "05555555555", "ahmet.yilmaz@example.com");
        Musteri musteri2 = new Musteri(2, "Ayşe", "Kara", "05554443322", "ayse.kara@example.com");
        
        musteriManager.MusteriEkle(musteri1);
        musteriManager.MusteriEkle(musteri2);
        
        // Müşteri listesi gösteriliyor
        musteriManager.MusteriListele();
        
        // Müşteri siliniyor
        musteriManager.MusteriSil(1);
        
        // Müşteri listesi tekrar gösteriliyor
        musteriManager.MusteriListele();
    }
}
