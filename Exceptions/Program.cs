using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] {"okan","okan2","okan3" };


            try
            {
                //hata olacagını düşündüğümüz kodu try içine yazıyoruz
                students[3] = "Ahmet";
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException); //daha detaylı bilgi veriri hata hakkında (varsa tabi bazen detay olmayabilir)

            }


            //ACTİON Delegasyonu ile prof hata yakalama

            HandleException(() =>
            {

                deneme();
               // students[3] = "Ahmet";
            });

         
       

        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

               
            }
        }





        public static void deneme()
        {
            Console.WriteLine("Deneme Fonk");
        }

    }
}
