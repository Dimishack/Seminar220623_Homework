using System;

namespace Seminar220623_Homework
{
    internal class Program
    {
        static void Main()
        {
			try
			{
				Console.WriteLine("Задание №4");
				Target04.MaxValue();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
        }
    }
}