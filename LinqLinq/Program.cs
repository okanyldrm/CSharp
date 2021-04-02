using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLinq
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Product> Products = new List<Product>();
            Products.Add(new Product() {Id = 1,Name = "product1",CategoryId = 1,Price = 100});
            Products.Add(new Product() { Id = 2, Name = "product2", CategoryId = 1, Price = 200 });
            Products.Add(new Product() { Id = 3, Name = "product3", CategoryId = 2, Price = 300 });
            Products.Add(new Product() { Id = 4, Name = "product4", CategoryId = 2, Price = 400 });
            Products.Add(new Product() { Id = 5, Name = "product5", CategoryId = 2, Price = 500 });

            var model = Products.Where(p => p.CategoryId == 1)
                .Select(pr => pr.Name);
         
               

            foreach (var mod in model)
            {
                Console.WriteLine(mod);
            }
          
            //eager nad layz
          

           




        }
    }
}
