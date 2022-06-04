using System;

namespace _1._0.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Type action:");
            char action = char.Parse(Console.ReadLine());
            Console.WriteLine("Type second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            double sum = 0;
            if (action == 43)
            {
                sum = firstNumber + secondNumber;
            }
            else if (action == 45)
            {
                sum = firstNumber - secondNumber;
            }
            else if (action == 42)
            {
                sum = firstNumber * secondNumber;
            }
            else if (action == 47)
            {
                sum = firstNumber / secondNumber;
            }

            if (action == 43 || action == 45 || action == 42)
            {
                Console.WriteLine($"Result from: {firstNumber} {action} {secondNumber} = {sum}");
            }
            else if (action == 47)
            {
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"Result from: {firstNumber} {action} {secondNumber} = {sum}");
                }
                else
                {
                    Console.WriteLine($"Result from: {firstNumber} {action} {secondNumber} = {sum:f2}");
                }

            }
            else
            {
                Console.WriteLine("Wrong action!");
            }

        }
    }
}
