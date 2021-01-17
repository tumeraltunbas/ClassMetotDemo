using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri kisi1 = new Musteri();
            kisi1.Id = 1111111111;
            kisi1.adSoyad = "Engin Demiroğ";
            kisi1.Yas = 35;
            kisi1.oturduguIl = "İstanbul";

            Musteri kisi2 = new Musteri();
            kisi2.Id = 222222222;
            kisi2.adSoyad = "Tümer Altunbaş";
            kisi2.Yas = 18;
            kisi2.oturduguIl = "İzmir";

            Musteri kisi3 = new Musteri();
            kisi3.Id = 333333333;
            kisi3.adSoyad = "Berkay Duman";
            kisi3.Yas = 24;
            kisi3.oturduguIl = "Antalya";

            Musteri kisi4 = new Musteri();
            kisi4.Id = 444444444;
            kisi4.adSoyad = "Murat Şahin";
            kisi4.Yas = 67;
            kisi4.oturduguIl = "Samsun";

            Musteri[] musteriler = new Musteri[] { kisi1, kisi2, kisi3, kisi4 }; 

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(kisi1);
            musteriManager.MusteriSil(kisi2);
            musteriManager.musteriList(musteriler);



        }
    }
}
