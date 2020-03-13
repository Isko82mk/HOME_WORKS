using System;

namespace Ex._1_SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = new double[6];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter integer no.1");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0;

            foreach (double number in numbers)
            {
                //Console.WriteLine($"Array numbers include this elements:{number}");
                sum += number;
                //Console.WriteLine($"The sum of arr numbers is{sum}");
            }

            double average = sum / 3;
            Console.WriteLine($"The average is : {Math.Round(average, 2) }");
            Console.Read();



        }
    }
}
