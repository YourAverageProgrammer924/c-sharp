namespace Zweites_Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1 - Programm starten");
            Console.WriteLine("2 - Programm beenden");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Bitte wählen Sie:");
            string wahl = Console.ReadLine();
            int wahlalszahl = Convert.ToInt32(wahl);

            if (wahlalszahl == 1)
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
                string zahl = Console.ReadLine();

                int meineVariable;
                meineVariable = Convert.ToInt32(zahl);

                Console.WriteLine("Sie haben die folgende Zahl eingegeben: " + meineVariable);
                Console.WriteLine("Schließen Sie das Programm mit einer belieben Taste");
                Console.ReadLine();
                



            }
            if (wahlalszahl == 2) 
            {
                System.Environment.Exit(0);

            }
            if (wahlalszahl != 1 || wahlalszahl == 2)
            {

                Console.WriteLine("FEHLER: ES SIND NUR DIE ZAHLEN 1 ODER 2 ALS EINGABE ERLAUBT!");
            
            
            }



            


        }
    }
}
