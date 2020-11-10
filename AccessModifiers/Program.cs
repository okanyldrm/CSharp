using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Customer
    {

        //private tanımlandığı blokta kullanılır. Default olarak private tanımlanır. int i = private'dir
        private int Id;

        //public her yerde erişilebilir

        //protected private'da ki gibi tanımlandığı blokta kullanılır AMA alt çocukları erişebilir kalıtım.
        protected int protec;
    }

    class Student : Customer
    {
        public void Save()
        {
            Console.WriteLine(protec);

        }
    }

    //class önünde her hangi belirteç yoksa defaultu internaldir
    //internal aynı proje içinde kullanılabilir CourseManagerde yaptığımız gibi rahatca erişebiliriz bu class'a.
    //bir class ya internal olur yada public olur. private olabilmesi için iç içe classlarda olur.
    internal class Course
    {
        public string Name { get; set; }

    }
}
