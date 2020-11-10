using System;
using System.Collections.Generic;

namespace GenericsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
           





        }
    }

    class Product : IEntity
    {

    }

    class Customer :IEntity
    {

    }

    interface IProductDal : IRepository<Product>
    {
        //List<Product> GetAll();
        //Product Get(int id);
        //void Add(Product product);
        //void Delete(Product product);
        //void Update(Product product);
    }


    interface ICustomerDal : IRepository<Customer>
    {
    //    List<Customer> GetAll();
    //    Customer Get(int id);
    //    void Add(Customer customer);
    //    void Delete(Customer customer);
    //    void Update(Customer customer);
    }


    interface IStudentDal : IRepository<Student>
    {

    }

    class Student :IEntity
    {

    }

    interface IEntity
    {
        //veri tabanı nesnesisin demek için IEntity interfasini product customer student bu IEntitiy'den interface alıyor

    }

    //generic Kısıtlar
    
    interface IRepository<T> where T:class,IEntity, new()
        //where T:class -> referans tip olabilir demek
        //new() -> newlenebilir olmalıdır (string newlenemez) class olmasını istiyosan en öenmlisi bu, bunu yazarsan classtır diyorsun
        //where T:struct deseydik deger tiplere izin veriyor generiğimiz
    {

        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }






   
}
