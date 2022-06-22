using System;

namespace _9_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int beginningOfRange = 0;
            int endOfRange = 28;
            int randomNumber = random.Next(beginningOfRange,endOfRange);
            int minimumRangeValue = 100;
            int maximumRangeValue = 1000;
            Console.WriteLine(randomNumber);

            for (int i = randomNumber; i < maximumRangeValue; i+= randomNumber)
            {
                if (minimumRangeValue <= i)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
