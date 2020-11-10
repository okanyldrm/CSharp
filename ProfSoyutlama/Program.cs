using System;

namespace ProfSoyutlama
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new SmsLogger();
            customerManager.Add();

            
        }


        class CustomerManager
        {
            public ILogger logger { get; set; }

            public void Add()
            {
                Console.WriteLine("Customer Add!");
                logger.Log();
            }



        }

        interface ILogger
        {
            void Log();
        }

        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Add to Database logger");
            }
        }

        class SmsLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Add to SMS logger");
            }
        }

    }
}
