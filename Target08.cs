using System;

namespace Seminar220623_Homework
{
    /*
     * Задача 8: Напишите программу, которая на вход принимает число (N), 
     * а на выходе показывает все чётные числа от 1 до N.
     * 5 -> 2, 4
     * 8 -> 2, 4, 6, 8
     */
    internal class Target08
    {
        internal static void EvenValues()
        {
            Console.Write("Введите число больше 0: ");
            var value = Int32.Parse(Console.ReadLine());
            if (value < 1)
                throw new Exception("Введено отрицательное число или 0");
            Console.Write("Все четные числа от 1 до {0}: ", value);
            for (int i = 1; i <= value; i++)
            {
                if (i % 2 == 0) Console.Write(i + ", ");
            }
        }
    }
}
