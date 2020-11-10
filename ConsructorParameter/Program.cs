using System;

namespace ConsructorParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager("Entity");
            personManager.Add();
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }


    }

    class PersonManager : BaseClass
    {


        public PersonManager(string entity):base(entity)
        {
            //base'e paramaetre geçirmek için aracılık yapan consructor!!
        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }

    }
}
