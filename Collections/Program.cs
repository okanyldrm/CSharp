using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////ArrayList bir collectiondur
            /// 
            //Tip belli değilse ArrayList çok iyi

            ArrayList cities = new ArrayList();


            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }



            ////////////////TypeSafe (Generic Collections) List<> -> Generic collectionsdur.

            List<string> sehirler = new List<string>();
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer {Id=1,FirstName="Okan" });


            //Collection Methodları
            var count=customers.Count; //eleman sayısı
            Customer customer = new Customer() { Id = 10, FirstName = "okan100" };
            customers.Add(new Customer { Id = 2, FirstName = "Okan2" }); //ekleme
            customers.Add(customer);
            customers.AddRange(new Customer[2] {  //dizi veya liste ekleme
            new Customer {Id=4,FirstName="okan4"},
            new Customer {Id=3,FirstName="okan3"}
            });
            customers.Clear(); //listeyi komple temizle
            var containss = customers.Contains(customer);

            customers.IndexOf(customer); //aradığımızın kaçıncı sırada oldugunu bulur.

            customers.LastIndexOf(customer); //aramaya sondan başlar kaçıncı sırada oldugunu bulur.

            customers.Insert(0,customer); //istediğimiz indexe ekleme yapar

            customers.Remove(customer); // customer'i silebiliriz (Buldugu ilk degeri uçurur fonksiyon durur sonra)

            customers.RemoveAll(c=>c.FirstName=="okan"); // bulduğu hepsini siler // ilk DELEGE örneği







            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
            }

            ///////////////////Dictionary Collectionu (Anahtar <<===>> Değer)
            ///Bir anahtarla hedefe ulaşmak istediğimiz zaman kullanıyoruz

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //anahtarı ver -> değeri versin
            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            //glass yok
            Console.WriteLine(dictionary.ContainsKey("glass"));
            //table var
            Console.WriteLine(dictionary.ContainsKey("table"));


        }
    }

    class Customer 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
