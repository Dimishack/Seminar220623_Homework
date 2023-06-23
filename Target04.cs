using System;

namespace Seminar220623_Homework
{
    /*
     * Задача 4: Напишите программу, 
     * которая принимает на вход три числа и выдаёт максимальное из этих чисел.
     * 2, 3, 7 -> 7
     * 44 5 78 -> 78
     * 22 3 9 -> 22
     */
    internal class Target04
    {
        internal static void MaxValue()
        {
            Console.Write("Введите первое число: ");
            var firstValue = Double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var secondValue = Double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            var thirdValue = Double.Parse(Console.ReadLine());
            var maxValue = firstValue;
            if (secondValue > maxValue)
                maxValue = secondValue;
            if (thirdValue > maxValue)
                maxValue = thirdValue;
            Console.WriteLine("Максимальное из этих чисел - " + maxValue);
        }
    }
}
