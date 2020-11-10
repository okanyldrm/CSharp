using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.FirstName = "Firtsname customer";
            Student student = new Student();
            student.Depertman = 1;
            student.FirstName = "student First name";

            Person[] persons = new Person[3] {

                new Customer(),new Student(), new Person()
            };
           
        }
    }


    //Inheritance birden fazla implement edilemez bir class tek bir classı kalıtlayabilir***
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }

    class Customer : Person
    {

    }

    class Student : Person
    {
        public int Depertman { get; set; }
    }
}
