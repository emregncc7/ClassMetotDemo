using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.musteriAdi = "Ahmet";
            musteri1.musteriSoyadi = "Yilmaz";
            musteri1.musteriAciklama = "xyz";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.musteriAdi = "Emre";
            musteri2.musteriSoyadi = "Genç";
            musteri2.musteriAciklama = "zxy";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2};
            foreach (var m in musteriler)
            {
                Console.WriteLine(m.Id);
                Console.WriteLine(m.musteriAdi);
                Console.WriteLine(m.musteriSoyadi);
                Console.WriteLine(m.musteriAciklama);
                Console.WriteLine("*****************************");
            }

            Console.WriteLine("*******Ekleme,Silme,Listele***********");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);


        }
    }
}
