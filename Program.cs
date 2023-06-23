using System;

namespace Seminar220623_Homework
{
    internal class Program
    {
        static void Main()
        {
			try
			{
				Console.WriteLine("Задание №2");
				Target02.MaxAndMin();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
        }
    }
}