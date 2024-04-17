namespace Datenstrukturen_Aufgabe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Fabienne<3");
            list.Add("Alex<3");
            list.Add("Kuschli<3");

            Console.WriteLine("Wert 1: " + list[0]);
            Console.WriteLine("Wert 2: " + list[1]);
            Console.WriteLine("Wert 3: " + list[2]);
            

        }
    }
}
