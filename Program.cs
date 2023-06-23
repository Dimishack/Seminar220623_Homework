using System;

namespace Seminar220623_Homework
{
	internal class Program
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Задание №6");
				Target06.EvenValue();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				Console.WriteLine("Для выхода из программы нажмите на любую клавишу...");
				Console.ReadKey(true);
			}
		}
	}
}