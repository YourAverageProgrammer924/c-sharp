namespace If_Verzweigung_Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie Ihren Nutzernamen ein: ");
            string nutzername = Console.ReadLine();

            if (nutzername == "Peter")
            {
                Console.WriteLine("Herzlich Willkommen!");

            }
            else {
                Console.WriteLine("Sie haben keine Berechtigung zur Nutzung des Programms.");
            }
        }
    }
}