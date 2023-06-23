using System;

namespace Seminar220623_Homework
{
    /*
     * Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
     * является ли число чётным (делится ли оно на два без остатка).
     * 4 -> да
     * -3 -> нет
     * 7 -> нет
     */
    internal class Target06
    {
        internal static void EvenValue()
        {
            Console.Write("Введите целое число: ");
            var value = Int32.Parse(Console.ReadLine());
            if (value % 2 == 0)
                Console.WriteLine("Число {0} является четным", value);
            else
                Console.WriteLine("Число {0} является нечетным", value);

        }
    }
}
