using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FindBiggestNumber
{
    internal static class Numbers
    {
        public static int BiggestNumber(int[] numbers)
        {
            //int[] mynumbers = { 2, 1, 7, 4, 9, 5 };
            //Array.Sort(numbers);

            int current = numbers[0];
            //int current = numbers.Min(x => x);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > current)
                    current = numbers[i];
            }
            return current;

            /*return numbers.Max();
            return numbers.Min();*/
            {
                Public static int SecondBiggestNumber(int[] numbers);
            }

            {
                int biggestnumber = SecondBiggestNumber(numbers);
                int SecondBiggestNumber = 0;
                //int Min = Math.Min(numbers[0], numbers[1];
                for (int i = 0; i < numbers.Length; i++) ;
            }
            {
                if (numbers[i] < BiggestNumber && numbers[i] > SecondBiggestNumber) ;
                    SecondBiggestNumber = numbers[i]; 
            }
            return SecondBiggestNumber;







        }