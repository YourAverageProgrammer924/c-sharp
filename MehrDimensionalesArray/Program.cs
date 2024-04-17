namespace MehrDimensionalesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] meinArray;
            meinArray = new int[4, 3];
            meinArray[0, 0] = 1;
            meinArray[0, 1] = 2;
            meinArray[0, 2] = 3;
            Console.WriteLine(meinArray[0, 0]);
            Console.WriteLine(meinArray[0, 1]);
            Console.WriteLine(meinArray[0, 2]);

            //nächtes Beispiel

            double[,] Artikel = new double[4, 3] { { 1001, 2.99, 23 }, { 1003, 8.49, 42 }, { 1004, 6.29, 61 }, { 1007, 10.99, 15 } };

            Console.WriteLine(Artikel[0, 0]);
            Console.WriteLine(Artikel[0, 1]);
            Console.WriteLine(Artikel[0, 2]);
        }
    }
}
