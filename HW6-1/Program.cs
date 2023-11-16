using System;

namespace Calculator
{
    class Program
    {
        static double Power(double baseNumber, int exponent)
        {
            
            if (exponent == 0)
            {
                return 1;
            }

            
            if (exponent < 0)
            {
                baseNumber = 1 / baseNumber;
                exponent = -exponent;
            }

            double result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите основание степени:");
            double baseNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите показатель степени:");
            int exponent = Convert.ToInt32(Console.ReadLine());

            double result = Power(baseNumber, exponent);
            Console.WriteLine($"Результат: {result}");
        }
    }
}