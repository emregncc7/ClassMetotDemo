using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine($"Musteri = {musteri.musteriAdi+" "+musteri.musteriSoyadi} listeye eklendi");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id);
            Console.WriteLine(musteri.musteriAdi);
            Console.WriteLine(musteri.musteriSoyadi);
            
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine($"Musteri = {musteri.musteriAdi + " " + musteri.musteriSoyadi} listeden silindi");
        }
    }
}
