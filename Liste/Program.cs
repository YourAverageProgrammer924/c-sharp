using System.Collections.Generic;
namespace Liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Liste = new List<int>();
            Liste.Add(5);
            Console.WriteLine("Der erste Wert in der Liste beträgt: " + Liste[0]);
            Liste.RemoveAt(0);
            Console.WriteLine("Nun wurde der Wert gelöscht: " + Liste.Count);

            //---------------------------------------------//

            List<int> meineListe = new List<int>();
            meineListe.Add(5);
            meineListe.Add(12);
            meineListe.Add(14);
            Console.WriteLine("Wert 1: " + meineListe[0]);
            Console.WriteLine("Wert 2: " + meineListe[1]);
            Console.WriteLine("Wert 3: " + meineListe[2]);
            Console.WriteLine("Länge: " + meineListe.Count);
            meineListe.Remove(12);
            meineListe[0] = 7;
            Console.WriteLine("Nach der Veränderung:");
            Console.WriteLine("Wert 1: " + meineListe[0]);
            Console.WriteLine("Wert 2: " + meineListe[1]);
            Console.WriteLine("Neue Länge: " + meineListe.Count);

        }
    }
}
