using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //müşterileri tutacak olan liste 
        List<Musteri> liste = new List<Musteri>();
        public void Add(Musteri musteri)
        {
            liste.Add(musteri); //liste'ye Add fonksiyonunun içine yazılan müşteriyi ekler.
            Console.WriteLine(musteri.MusteriName + " " + musteri.MusteriSurname + " başarıyla eklendi." + "\n");
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public void Delete(Musteri musteri)
        {
            int id = musteri.Id; //silinmek istenen müşterinin id bilgisini musteri.id ile aldı ve o integer
            //değeri id adında bir değişkene atadı.
            //removeat fonksiyonu index bazlı çalıştığında içine yazılan sayı index i söyler. listelerde
            //elemanlar 0'dan itibaren index vererek sayıldığından 2. elemanı silmek istiyorsak index 1 seçilmelidir.
            //burda musterileri ıd sırasıyla ekledğim ve 1'den itibaren rakam vererek atadığım için silinmek istenen 
            //müşterinin id sinin 1 eksiği onun index i olur.
            liste.RemoveAt(id-1);


            Console.WriteLine("-----------------------------------------------------------------");
            //silinen müşterinin adını ve soy adını yazdırma
            Console.WriteLine(musteri.MusteriName+" "+musteri.MusteriSurname+" başarıyla silindi."+"\n");
            Console.WriteLine("-----------------------------------------------------------------");
        }


        public void Listele()
        {
            foreach (var item in liste) //liste adındaki listedeki tüm müşterilerin istenilen özelliklerini sıralar.
            {
                Console.WriteLine("Id: " + item.Id + "\n" + "Müşteri Ad-Soyad: " + item.MusteriName + item.MusteriSurname
                    + "\n" + "TC no: " + item.TcNum + "\n" +
                    "Card no:" + item.CardNo + "\n");
            }
        }
    }

       
    
}
