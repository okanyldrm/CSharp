using System;
using System.Linq;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {


            Show();
            Show2(2,4);
            var sum = Add(2, 4);
            Console.WriteLine("SUM: {0}", sum);



            //default parameter function
            var sum2 = Add2(2,5);
            var sum3 = Add2(2);
            Console.WriteLine("Default sum 1 Add2(2+5): {0}", sum2);
            Console.WriteLine("Default sum 2 Add2(2)(default number2=10): {0}", sum3);


            //ref Keyword
            int number1 = 10;
            int number2 = 100;
            var refResult=refAdd(ref number1, number2);
            Console.WriteLine("RefResult: {0} | Number1: {1}", refResult,number1);

            //params Keyword
            var paramResult = ParamAdd(10, 2, 2, 2, 2);
            Console.WriteLine("Param Result: {0}", paramResult);
      


        }


        //function definition
        //static = static bir metodun içinde kullanacağım için fonksiyonun static olması lazım
        static void Show()
        {
            Console.WriteLine("Add function work");
        }


        //parameter functions

        static void Show2(int number1,int number2) 
        {
            Console.WriteLine("{0} -- {1}", number1, number2);
        }


        //return functions
        static int Add(int number1,int number2) 
        {
            return number1 + number2;
        }


        //default parameter function
        static int Add2(int number1,int number2=10) 
        {
            return number1 + number2;
        }


        //REF Keyword!!!!!!!!
      
        
        static int refAdd(ref int number1, int number2) 
        
        {
            //number1 = 30;
            return number1 + number2;
        }

        //method overloading

        //aynı fonksiyon adına sahip başka bir fonksiyon oluşturulabilir
        //ama aldıkları parametreler farklı olmak şartıyla
        //buna overloading denir

        static void OverMethod(int a, int b) { }
        static void OverMethod(int a, int b, int c) { }

        //params keyword
        //birden fazla girdi almak için kullanılır.

        static int ParamAdd(int number1, params int[] numbers) {

            return number1 + numbers.Sum();
        }



    }
}
