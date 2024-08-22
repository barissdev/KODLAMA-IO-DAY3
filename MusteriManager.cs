public class MusteriManager
{
    private List<Musteri> musteriler = new List<Musteri>();

    public void MusteriEkle(Musteri musteri)
    {
        musteriler.Add(musteri);
        Console.WriteLine("Müşteri eklendi: " + musteri.ToString());
    }

    public void MusteriSil(int id)
    {
        Musteri musteri = musteriler.FirstOrDefault(m => m.Id == id);
        if (musteri != null)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("Müşteri silindi: " + musteri.ToString());
        }
        else
        {
            Console.WriteLine("Müşteri bulunamadı.");
        }
    }

    public void MusteriListele()
    {
        Console.WriteLine("Müşteri Listesi:");
        foreach (var musteri in musteriler)
        {
            Console.WriteLine(musteri.ToString());
        }
    }
}
