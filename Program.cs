using System;
using System.Collections.Generic;

namespace CodeBlogForForeachWhile
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			int Summ = 0;

			for (int i = 0; i < 3; i++)
			{
				if (int.TryParse(Console.ReadLine(), out int result))
				{
					list.Add(result);
					Summ += result;
				}
				else
				{
					Console.WriteLine("Введите число");
				}
			}
		
			var k = 1;
			var SummMin = list[0];
			while (k < list.Count)
			{
				SummMin -= list[k];
				k++;
			}

			foreach (int item in list)
			{
				Console.WriteLine("item: " + item);
			}

			var j = 1;
			var Composition = list[0];

			do
			{
				Composition *= list[j];
			} while (j < list.Count);

			Console.WriteLine("Сумма: " + Summ);
			Console.WriteLine("Разность: " + SummMin);
			Console.WriteLine("Произведение: " + Composition);
			Console.ReadLine();
		}
	}
}
