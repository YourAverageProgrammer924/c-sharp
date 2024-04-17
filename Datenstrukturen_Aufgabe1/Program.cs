namespace Datenstrukturen_Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };

            ints[0] = ints[0] + 1;
            ints[1] = ints[1] + 1;
            ints[2] = ints[2] + 1;

            Console.WriteLine(ints[0]);
            Console.WriteLine(ints[1]);
            Console.WriteLine(ints[2]);
        }
    }
}
