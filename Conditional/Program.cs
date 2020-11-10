using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {

            //if

            int number1 = 11;

            if (number1==11)
            {
                Console.WriteLine("Number is 11");
            }
            else
            {
                Console.WriteLine("Number is not 11");
            }

            //single if

            var number2 = 12;

            Console.WriteLine(number2 == 10 ? "Number is 10" : "Number is not 10"); //  (conditional ? work true : work false )


            //else if

            int number3 = 12;

            if (number3 == 12)
            {

            }
            else if (number3 == 13)
            {

            }
            else if (number3 ==14)
            { 

            }
            else
            {

            }


            //switch

            int number5 = 10;

            switch (number5)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            // multiple conditional 
            // >= ,  <= , == , != , < , >
            // && => and , || => or




            //nested condition

            if (true)
            {
                if (true)
                {
                    if (false)
                    { 
                    }
                    else
                    {
                    }
                }
            }




        }
    }
}
