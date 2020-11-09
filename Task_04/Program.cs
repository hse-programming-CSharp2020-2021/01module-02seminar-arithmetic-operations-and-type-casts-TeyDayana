/*
 * Задача : 
 * Получить от пользователя четырехзначное натуральное число 
 * и напечатать его цифры в обратном порядке.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1234
 * -------test_2-------
 * 5669
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4321
 * -------test_2-------
 * 9665
 * --------------------
 */

using System;
using System.Globalization;

namespace Task_03
{
	class Program
	{
		static void Main(string[] args)
		{
			// TODO : Сменить локаль на "ru-RU". 
			CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

			int number = int.Parse(Console.ReadLine());

			while (number > 0)
            {
				Console.Write(number % 10);
				number /= 10;
            }
			Console.Write("\n");
		}
	}
}
