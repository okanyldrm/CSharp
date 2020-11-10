using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //contructor newlenirken ilk çalışan metoddur
            //new CustomerManager()'deki ()->bu aslında constructora parametre geçirme anlamına gelir.
            //parametere geçirmek için CustomerManager class'ında constructorda parametre girdisi istenir new'lenirken parametre girilir.!!
            CustomerManager customerManager = new CustomerManager(12);
            customerManager.Add();
            /////
            ///
            Product product = new Product(); // böyle boşta başlatabilir
            Product product2 = new Product(2,"Laptop"); //böyle constructor ilede başlatabilir her ikisininde ctor'u yazıldı.
        }



        class CustomerManager
        {
            int _count;
            public CustomerManager(int count)
            {
                _count = count;
            }
            public void Add()
            {
                Console.WriteLine("Added {0}", _count);
            }
        }

        class Product
        {

            public Product()
            {

            }


            int _id;
            string _name;
            public Product(int id,string name)
            {
                _id = id;
                _name = name;
            }
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
