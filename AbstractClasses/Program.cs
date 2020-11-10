using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Database db = new SqlServer();
            db.Add();
            db.Delete();

        }
    }

    //interfacelerle virtual methodların birleşimi gibi düşünebiliriz Abstract Class'ları 


    abstract class Database
    {

        //abstract classlarda hem tamamlanmıi hemde tamamlanmamış methodlar yazabiliyoruz.


        //ekleme tüm veritabanlarında aynıdır (fakat delete farklıdır mesela)
        public void Add()
        {
            Console.WriteLine("Add by default");
        }


        public abstract void Delete();




    }


    class SqlServer : Database
    {
        public override void Delete()
        {
            //interfacedeki gibi database'den aldıgı tamamlanmamış fonksiyonu implement etmeni ister.
            Console.WriteLine("Sql server Delete");
        }
    }







}
