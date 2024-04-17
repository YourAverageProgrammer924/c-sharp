using System;
namespace Logische_Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Was ist das Ergebnis aus 2+4? ");
            int ergebnis1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Was ist das Ergebnis aus 5+7? ");
            int ergebnis2 = int.Parse(Console.ReadLine());
            if ((ergebnis1 == 6) & (ergebnis2 == 12))
            {
                Console.WriteLine("Sie haben beide Aufgaben richtig gelöst");
            }
            if ((ergebnis1 == 6) | (ergebnis2 == 12))
            {
                Console.WriteLine("Sie haben nur eine Aufgabe richtig gelöst");

            }

            if ((ergebnis1 != 6) & (ergebnis2 != 12))
            {
                Console.WriteLine("Sie haben beide Aufgaben falsch gelöst");
            }
        }
    }

}