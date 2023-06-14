﻿namespace FactorialApp
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }

        public static long CalculateFactorial(int number)
        {
            if (number == 0 || number == 1)
            {
               
                return 1;

            }
            else if (number > 1)
            {
                return number * CalculateFactorial(number - 1);
            }
            else
            {



                throw new NotImplementedException();
            }
        }

    }
}