using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            BestMyList<string> isimler = new BestMyList<string>();
            isimler.Add("Kadriye");
            isimler.Add("Mustafa");
            isimler.Add("Şenol");

            Console.WriteLine("İsimler length = " + isimler.Length);

            Console.WriteLine("--------isimler--------");
            foreach (var item in isimler.Kitem)
            {
                Console.WriteLine(item);
            }

        }
    }
}
