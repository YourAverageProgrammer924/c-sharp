namespace Vergleichsoperatoren_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Was ist das Ergebnis aus 2+4? ");
            int ergebnis = int.Parse(Console.ReadLine());
            bool bedingung1 = ergebnis == 6;

            if (bedingung1) 
            {
                Console.WriteLine("Sie haben die Aufgabe richtig gelöst.");
            }

            bool bedingung2 = ergebnis != 6;
            if (bedingung2) 
            {
                Console.WriteLine("Sie haben die Aufgabe nicht richtig gelöst.");
            }

        }
    }
}
