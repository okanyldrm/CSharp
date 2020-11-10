using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}",i);
            }

            //while
            int j = 0;
            while (j<10)
            {
                Console.WriteLine("{0}", j);
                j++;
            }


            //do while
            int k = 0;
            do
            {
                Console.WriteLine("{0}", k);
                k++;
            } while (k<10);

            //foreach

            string[] students = { "a", "b", "c", "d" };

            foreach (var item in students)
            {
                Console.WriteLine("{0}", item);
            }


        }
    }
}
