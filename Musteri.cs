public class Musteri
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string TelefonNumarasi { get; set; }
    public string Email { get; set; }
    
    public Musteri(int id, string ad, string soyad, string telefonNumarasi, string email)
    {
        Id = id;
        Ad = ad;
        Soyad = soyad;
        TelefonNumarasi = telefonNumarasi;
        Email = email;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Ad: {Ad}, Soyad: {Soyad}, Telefon: {TelefonNumarasi}, Email: {Email}";
    }
}
