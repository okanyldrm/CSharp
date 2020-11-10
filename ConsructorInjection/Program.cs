using System;

namespace ConsructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();
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
            Console.WriteLine("Database Logger");
        }
    }


    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Logger");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }



    }


}
