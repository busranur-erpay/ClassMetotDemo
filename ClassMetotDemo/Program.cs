using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //müşteri tanımlama
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriName = "Yaren";
            musteri1.MusteriSurname = "Sönmez";
            musteri1.TcNum ="57521215764";
            musteri1.CardNo = "3264752456565645";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriName = "Deniz";
            musteri2.MusteriSurname = "Ak";
            musteri2.TcNum = "78413655764";
            musteri2.CardNo = "7586752456565645";


            Musteri[] musteriler = new Musteri[] { };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Listele();

            musteriManager.Delete(musteri2);
            musteriManager.Listele(); //eleman sildikten sonra listeleme
        }
    }
}
