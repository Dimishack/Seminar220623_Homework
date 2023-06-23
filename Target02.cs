using System;

namespace Seminar220623_Homework
{
    /*
     * Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
     какое число большее, а какое меньшее.
     * a = 5; b = 7 -> max = 7
     * a = 2 b = 10 -> max = 10
     * a = -9 b = -3 -> max = -3
    */
    internal class Target02
    {
        internal static void MaxAndMin()
        {
            Console.Write("Введите первое число: ");
            var firstValue = Double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var secondValue = Double.Parse(Console.ReadLine());
            if (firstValue > secondValue)
                Console.WriteLine("Большее число - {0} \nМеньшее число - {1}", firstValue, secondValue);
            else if (secondValue > firstValue)
                Console.WriteLine("Большее число - {0} \nМеньшее число - {1}", secondValue, firstValue);
            else
                Console.WriteLine("Числа равны");
        }
    }
}
