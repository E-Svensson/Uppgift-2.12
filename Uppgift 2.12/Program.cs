using System;

namespace Uppgift_212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I hur många dagar tänker du hyra bilen?");
            Console.Write("Svara här: "); string strDagar = Console.ReadLine();
            Console.WriteLine("Och hur långt tänker du köra med bilen? (km)");
            Console.Write("Svara här: "); string strSträcka = Console.ReadLine();

            int intDagar = int.Parse(strDagar);
            int intSträcka = int.Parse(strSträcka);

            int Summa = 300 + intDagar * 500 + intSträcka * 1;

            Console.WriteLine("Det kommer kosta dig " + Summa + "kr");
        }
    }
}