namespace FuenftesProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] Preisliste = new double[4] { 2.99, 8.49, 6.29, 10.99 };

            Console.WriteLine("Preis Produkt 1: " + Preisliste[0]);
            Console.WriteLine("Preis Produkt 2: " + Preisliste[1]);
            Console.WriteLine("Preis Produkt 3: " + Preisliste[2]);
            Console.WriteLine("Preis Produkt 4: " + Preisliste[3]);

            Preisliste[1] = 7.99;
            Console.WriteLine("Neuer Preis Produkt 2: " + Preisliste[1]);
        }
    }
}
