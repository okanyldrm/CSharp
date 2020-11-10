using System;
using System.IO;
using System.Linq;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dosya Path'i
            string path = @"C:\filecsharp\deneme.txt";

            //DOSYADAN VERİ OKUMA********************

            //Tamamını okuma
            string metin = System.IO.File.ReadAllText(path);
            Console.WriteLine(metin);

            //satir-satir okuma
            string[] satirlar = System.IO.File.ReadAllLines(path);
            Console.WriteLine(satirlar.Length);

            foreach (var satir in satirlar)
            {
                Console.WriteLine(satir);
            }

            //DOSYAYA VERİ YAZMA********************
            
            string[] satirlar1 = {"eklenen1", "eklenen2", "eklenen3"};
            string str = "eklenen tek string";

            System.IO.File.WriteAllLines(path,satirlar1);
            System.IO.File.WriteAllText(path,str);




            string[] dizi = {"personel = okan", "personel = okan1", "personel = okan2", "müdür", "müdür", "müdür", "müdür" };

            using (System.IO.StreamWriter dosya = new StreamWriter(path))
            {
                foreach (var satirtut in dizi)
                {
                    if (satirtut.Contains("personel"))
                    {
                        dosya.WriteLine(satirtut);
                    }
                }
            }

            //silmeden ekleme önemli **********************************************************
            using (System.IO.StreamWriter dosya = new StreamWriter(path,true))
            {
                dosya.WriteLine("yeni eklenen eleman");
             



            }

        }
    }
}
