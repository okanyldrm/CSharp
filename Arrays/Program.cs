using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array definitation 1
            string[] students = new string[3];
            students[0] = "Okan";
            //Console.WriteLine(students[0]);

            //Array definitation 2 
            //[eleman sayısı]
            string[] students2 = new string[2] { "aa", "bb" };

            //Array definitation 3 
            string[] students3 = { "aaa", "bbb", "ccc" };



            //Array foreach (Arrayde gezinme)

            foreach (var student in students3) {
                Console.WriteLine(student);
            }


        }
    }
}
