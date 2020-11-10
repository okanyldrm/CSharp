using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int number1 = 10;
            long number2 = 20;
            short number3 = 1;
            byte number4 = 255; //-255 +255
            bool conditional = true;
            char character = 'A';
            double double1 = 10.4;
            decimal decimal1 = 10.4m; // m yazmak lazım araştır sonra...




            //ENUM
            Console.WriteLine(Days.Friday);

            //WriteLine
            Console.WriteLine("Number1 is {0}", number1);

            //var keyword
            var number5 = 12; //başta ne verildiyse o tipte devam eder.

            



        }
        //ENUM
        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Satuday,Sunday
        }
    }
}
