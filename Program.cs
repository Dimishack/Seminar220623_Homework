using System;

namespace Seminar220623_Homework
{
	internal class Program
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Задание №8");
				Target08.EvenValues();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				Console.WriteLine("\nДля выхода из программы нажмите на любую клавишу...");
				Console.ReadKey(true);
			}
		}
	}
}