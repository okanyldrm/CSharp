using System;

namespace StaticClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //newleme yok
            Teacher.Number=10;

            Utilities.Validate();


            Manager.DoSomething();

            //manager2 için instance oluşturmak şark çünkü metod statik değil
            Manager manager = new Manager();
            manager.DoSomething2();

        }
    }


    static class Teacher
    {
        //static nesneler new'lenmez!! Tek bir nesne oluşturuluyor herkes o nesneyi tüketiyor!.

        public static int Number { get; set; }
    }

    static class Utilities
    {
        //sıklıkla kullandıgımız araçları validation(Dogrulama) vs 

        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    

    class Manager
    {
        //class static değil ama özellikler static olabilir
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }


    }


            
}
