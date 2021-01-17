using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi." + " : " + musteri.adSoyad);
        }
         
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi." + " : " + musteri.adSoyad);
        }
        public void musteriList (Musteri[] musteri)
        {
            Console.WriteLine("Müşteri Listesi");
            foreach (var mbilgi in musteri)
            {
                Console.WriteLine(mbilgi.Id + " : " + mbilgi.adSoyad + " : " + mbilgi.Yas + " : " + mbilgi.oturduguIl);
            }
          
        }
    }
}
