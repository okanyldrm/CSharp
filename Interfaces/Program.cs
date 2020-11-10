using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //personManager.Add(new Customer { Id=1});
            //personManager.Add(new Student { Id = 2 });

            //Interface newlenemez
            //ama customer newlenir
            IPerson person = new Customer();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());



        }
    }


    //interface isimlendirme başında I konulur
    //soyut sınıftır
    interface IPerson
    {
        // interfacelerde erişim bilgirgeci belirmiyosun public private vs gibi
        int Id { get; set; }

    }



    class Customer : IPerson
    {
        public int Id { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Id+" Eklendi");
        }

    }
}
