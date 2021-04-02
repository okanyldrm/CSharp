using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace HexadecimalConvert
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter Hexa Data");
           var hexaString=Console.ReadLine();

            var data = Converting(hexaString);
            var result=HexaConvert(data);
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }



        public static List<int> Converting(string hexadecimalData)
        {
           
            List<int> forthData = new List<int>();

            for (int i = 0; i < hexadecimalData.Length/4; i++)
            {
                var item = Int32.Parse(hexadecimalData.Substring(i * 4, 4));
                forthData.Add(item);
            }

            return forthData;
        }

        public static List<string> HexaConvert(List<int> data)
        {
            List<string> result = new List<string>();

            foreach (var item in data)
            {
                switch (item)
                {
                    case 0000:
                        result.Add("0");
                        break;
                    case 0001:
                        result.Add("1");
                        break;
                    case 0010:
                        result.Add("2");
                        break;
                    case 0011:
                        result.Add("3");
                        break;
                    case 0100:
                        result.Add("4");
                        break;
                    case 0101:
                        result.Add("5");
                        break;
                    case 0110:
                        result.Add("6");
                        break;
                    case 0111:
                        result.Add("7");
                        break;
                    case 1000:
                        result.Add("8");
                        break;
                    case 1001:
                        result.Add("9");
                        break;
                    case 1010:
                        result.Add("A");
                        break;
                    case 1011:
                        result.Add("B");
                        break;
                    case 1100:
                        result.Add("C");
                        break;
                    case 1101:
                        result.Add("D");
                        break;
                    case 1110:
                        result.Add("E");
                        break;
                    case 1111:
                        result.Add("F");
                        break;
                }
            }

            return result;

        }



    }
}
