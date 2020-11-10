using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentences = "My name is okan";

            var resultlength=sentences.Length;
            var resultclone = sentences.Clone(); //Clone başka yeni bir değişken oluşturdu YENİ REFERANS OLUŞTu
            bool resultendswith=sentences.EndsWith("n"); //Cümle ne ile bitiyor.
            bool resultstartwith = sentences.StartsWith("o"); //Cümle ne ile başlıyor.
            var resultindexof = sentences.IndexOf("name"); //Belli bir karakter yada ifade aramak için kullanılır. bulamadığında -1 döner
            var resultinsert = sentences.Insert(0, "Hello ");
            var resultsubstring = sentences.Substring(0, 5);
            var resulttolower = sentences.ToLower();
            var resulttoupper = sentences.ToUpper();
            var resultreplace = sentences.Replace(" ","%");
            var resultremove = sentences.Remove(2, 4); // belli bir indexten sonrasını atmak için yada aralık



            Console.WriteLine(resultremove);
            Console.WriteLine(sentences);




        }
    }
}
