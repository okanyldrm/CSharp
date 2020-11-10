using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //class tanımlama kullanma
            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();
            customerManager.Add();
            customerManager.Update();
            productManager.Add();
            productManager.Delete();


            //property
            //1
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Okan";
            //2
            Customer customer2 = new Customer {Id=2,Name="Okan2" };

            Console.WriteLine(customer.Name);


        }
    }


    class CustomerManager 
    
    { 
        public void Add()
        {
            Console.WriteLine("Customer Add");
        }
    
        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    
    }

}
