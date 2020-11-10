using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            Console.WriteLine("adasdsad");
            MysqlServer mysql = new MysqlServer();
            mysql.Delete();
            mysql.Add();
        }


        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Add by default");

            }

            public void Delete()
            {
                Console.WriteLine("Deleted by default");
            }
        }

        class SqlServer : Database
        {
            public override void Add()
            {

                // babadan gelen Add() methodu'nu değiştirmek yani override etmek istersen babadaki(Database) method virtual olacak.
                //base.Add();
               Console.WriteLine("SqlServer Add Code!");

            }

            //delete override edilemez çünkü basede virtual tanımlanmamış!!!
        }

        class MysqlServer : Database
        {

        }
    }
}
