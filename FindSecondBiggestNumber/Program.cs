using System.Globalization;

namespace FindSecondBiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mynumbers = { 9, 1, 7, 4, 2, 5 };
            int SecondBiggest = NumberStyles.SecondBiggestNumber(mynumbers);
            Console.WriteLine(SecondBiggest);
        }
    }
}