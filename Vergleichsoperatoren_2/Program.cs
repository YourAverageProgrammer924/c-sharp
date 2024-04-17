namespace Vergleichsoperatoren_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Was ist das Ergebnis aus 2+4");
            int ergebnis = int.Parse(Console.ReadLine());
            if (ergebnis == 6)
            {
                Console.WriteLine("Sie haben die Aufgabe richtig gelöst");
            }
            if (ergebnis != 6)
            { 
                Console.WriteLine("Sie haben die Aufgabe nicht richtig gelöst.");
            }
        }
    }
}
