/*
 * Задача : 
 * Получить от пользователя вещественное значение – бюджет пользователя и целое число – процент бюджета, 
 * выделенный на компьютерные игры. Вычислить и вывести на экран сумму в долларах, 
 * выделенную на компьютерные игры. С точностью до 2-х знаков после запятой. 
 * !!!Использовать спецификаторы формата для валют.!!!
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1300
 * 10
 * -------test_2-------
 * 1000.50
 * 5
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * $130.00
 * -------test_2-------
 * $50.03
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
			double sum = double.Parse(Console.ReadLine().Replace(',','.'));
			int percent = int.Parse(Console.ReadLine()); 
			// TODO : Считать вещественную и целочисленную переменную.

			// TODO : Рассчитать бюджет на игры.
			double onComputerGames = sum * percent / 100;


            Console.WriteLine(onComputerGames.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
		}
	}
}
