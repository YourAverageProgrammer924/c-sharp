using System.Collections;
namespace ArrayListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList meineListe = new ArrayList();
            meineListe.Add(25);
            meineListe.Add("Hello");
            meineListe.Add(true);
            meineListe.Add(3.44);
            Console.WriteLine("Wert 1: " + meineListe[0]);
            Console.WriteLine("Wert 2: " + meineListe[1]);
            Console.WriteLine("Wert 3: " + meineListe[2]);
            Console.WriteLine("Wert 4: " + meineListe[3]);
            meineListe.RemoveAt(2);
            meineListe.Remove("Hallo");
            Console.WriteLine("Länge: " + meineListe.Count);


        }
    }
}
