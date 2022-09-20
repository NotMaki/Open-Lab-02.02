using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            Console.Write(Math.Round(numbers[0], 2) + " ");
            Console.Write(Math.Round(numbers[1], 2) + " ");
            Console.Write(Math.Round(numbers[2], 2) + " ");
            Console.Write(Math.Round(numbers[3], 2) + " ");
            Console.Write(Math.Round(numbers[4], 2));
        }
    }
}
