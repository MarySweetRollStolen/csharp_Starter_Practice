using System;

namespace csharp_Starter_Practice
{
    class Program
    {

        static int SquareSum(params int[] rowOfNumbers)
        {
            int sum = 0;
            foreach(int element in rowOfNumbers)
            {
                sum += element * element;
            }
            return sum;
        }

        static int GiveNumberOfVowels(string text)
        {
            text = text.ToLower();
            int count = 0;
            foreach (int element in text)
            {
                bool isVowelsel = element == 'a' || element == 'e' || element == 'i' || element == 'o' || element == 'u';
                if (isVowelsel)
                {
                    count++;
                }
            }
            return count;
        }

        static string Repeater(string text, int repetitionCount)
        {
            string result = "";
            for(var i=0; i< repetitionCount; i++)
            {
                result += text;
            }
            return result;
        }

        static void GetMaxMinPrice(out double min, out double max, params double[] priceList)
        {
            Array.Sort(priceList);
            min = priceList[0];
            max = priceList[priceList.Length - 1];
        }


        static void Main(string[] args)
        {
            {
                Console.WriteLine("complete the square sum function");
                int[] arrrr = { 2, 2, 2, 2 };
                Console.WriteLine(SquareSum(arrrr));
                Console.WriteLine(SquareSum(1, 2, 2));
                Console.WriteLine(SquareSum(1, 1, 1));
                Console.WriteLine(SquareSum(2, 2, 2));
                Console.WriteLine(SquareSum(1, 2, 2, 2));
                Console.WriteLine(SquareSum(2, 2, 2, 1));
            }


            {
                Console.WriteLine("\nthe number of vowels in the given string");
                Console.WriteLine(GiveNumberOfVowels("Return"));
                Console.WriteLine(GiveNumberOfVowels("number"));
                Console.WriteLine(GiveNumberOfVowels("why"));
                Console.WriteLine(GiveNumberOfVowels("And/Or spaces"));
            }

            {
                Console.WriteLine("\na function named repeater()");
                Console.WriteLine(Repeater("a", 5));
                Console.WriteLine(Repeater("love", 6));
                Console.WriteLine(Repeater("bee", 2));
            }
            {
                Console.WriteLine("\nfunction that returns both the minimum and maximum number");
                double min, max;
                GetMaxMinPrice(out min, out max, 1, 2, 3, 4, 5);
                Console.WriteLine($"max = {max}, min = {min}");
                GetMaxMinPrice(out min, out max, 5, 4, 24, 5, 4, 4, 4);
                Console.WriteLine($"max = {max}, min = {min}");
                GetMaxMinPrice(out min, out max, 74, 4);
                Console.WriteLine($"max = {max}, min = {min}");
            }

        }

    }
}
