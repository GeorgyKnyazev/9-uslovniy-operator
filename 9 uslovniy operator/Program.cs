using System;

namespace _9_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0,28);
            int minimumRangeValue = 100;
            int maximumRangeValue = 1000;
            Console.WriteLine(randomNumber);

            for (int i = randomNumber; i < maximumRangeValue; i+= randomNumber)
            {
                if (i <= minimumRangeValue)
                {
                    continue;
                }
                else if (minimumRangeValue <= i || i < maximumRangeValue)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
