using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> cityPlate = new MyDictionary<string,int>();
            cityPlate.Add("Ankara", 06);
            cityPlate.Add("İstanbul", 34);
            cityPlate.Add("Düzce", 81);

            Console.WriteLine("Şehir sayısı : " + cityPlate.Count);
            Console.WriteLine();

            foreach (var item in cityPlate.DictionaryKey)
            {
                Console.WriteLine(item);
            }

        }
    }
}

