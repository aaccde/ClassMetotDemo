using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager

    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" Eklendi.");
        }
       public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Listelendi");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Silindi.");
        }
    }
}
