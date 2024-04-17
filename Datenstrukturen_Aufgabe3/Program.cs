using System.Collections;

namespace Datenstrukturen_Aufgabe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            liste.Add(true);
            liste.Add("hello");
            liste.Add(2);
            liste.RemoveAt(1);
            Console.WriteLine(liste[0]);
            Console.WriteLine(liste[1]);


            
        }
    }
}
