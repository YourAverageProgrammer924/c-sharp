using System;

namespace Else_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Was ist das Ergebnis aus 2+4? ");
            int ergebnis1 = int.Parse(Console.ReadLine());
            Console.Write("Was ist das Ergebnis aus 5+7");
            int ergebnis2 = int.Parse(Console.ReadLine());

            if ((ergebnis1 == 6) & (ergebnis2 == 12))
            {
                Console.WriteLine("Sie haben beide Aufgaben richtig gelöst");
            }
            else if ((ergebnis1 == 6) | (ergebnis2 == 12))
            {
                Console.WriteLine("Sie haben nur eine richtig gelöst");
            }
            else
            {
                Console.WriteLine("Sie haben beide Aufgaben falsch gelöst.");
            }
        }
    }
}