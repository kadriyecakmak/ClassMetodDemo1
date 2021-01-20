using System;

namespace Genericsİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Bilgisayarım zor durumda :(");

            Console.WriteLine("Hello World!");
        }
    }
}
