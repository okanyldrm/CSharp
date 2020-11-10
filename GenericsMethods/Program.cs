using System;
using System.Collections.Generic;

namespace GenericsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İstanbul", "İzmir");

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName="Okan"},new Customer { FirstName="Okan2"});

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items) 
        {
            return new List<T>(items);
        }
    }

    class Customer
    {
        public string FirstName { get; set; }

    }
}
