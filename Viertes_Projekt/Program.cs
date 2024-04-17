using System.Runtime.ConstrainedExecution;

namespace Viertes_Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Information: Sie werden gleich Zahlen eingeben müssen. Sie könnnen auch Kommazahlen eingeben.");
            Console.Write("Haben Sie diese Information verstanden? (j/n) : ");
            string verstaendnis = Console.ReadLine();

            if (verstaendnis == "j")
            {
                Console.Write("Hallo Anwender, bitte gebe eine Zahl ein: ");
                double wert1 = double.Parse(Console.ReadLine());

                Console.Write("Hallo Anwender, bitte gebe eine zweite Zahl ein: ");

                double wert2 = double.Parse(Console.ReadLine());


                double ergebnis_addition  = wert1 + wert2;
                double ergebnis_subtraktion = wert1 - wert2;
                double ergebnis_multiplikation = wert1 * wert2;
                double ergebnis_division = wert1 / wert2;



                Console.WriteLine("Ausgabe Ergebnis der Additon: " + ergebnis_addition);
                Console.WriteLine("Ausgabe Ergebnis der Subtraktion: " + ergebnis_subtraktion);
                Console.WriteLine("Ausgabe Ergebnis der Multiplikation: " + ergebnis_multiplikation);
                Console.WriteLine("Ausgabe Ergebnis der Division: " + ergebnis_division);




            }
            else
            {

                Console.Write("Das Programm wird nun beendet.");
                System.Environment.Exit(0);

            }



        }
    }
}
