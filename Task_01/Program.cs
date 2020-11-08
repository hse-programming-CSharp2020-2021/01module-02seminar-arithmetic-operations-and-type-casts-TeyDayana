﻿/*
 * Задача : 
 * Ввести значение x и вывести значение полинома: F(x) = 12x^4 + 9x^3 - 3x^2 + 2x – 4. 
 * С точностью до 2-х знаков после запятой. 
 * !!! Не применять возведение в степень. !!!
 * Использовать минимальное количество операций умножения. 
 * (Алгоритм быстрого возведения в степень : https://e-maxx.ru/algo/binary_pow)
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1
 * -------test_2-------
 * 0
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 16,00
 * -------test_2-------
 * -4,00
 * --------------------
 * 
 * Тестирование будет проводиться на машинах с английской локалью, где в качестве разделителя в 
 * вещественных числах используется точка. Чтобы выводилась запятая надо принудительно сменить локаль на русскую.
 */

using System;
using System.Globalization;

namespace Task_01 {
	class Program {
		static void Main(string[] args) {
			CultureInfo c = new CultureInfo("ru-RU");

			double x;
			// Ввод данных. 
			x = double.Parse(Console.ReadLine());

			// Вычисление и вывод данных.
			Console.WriteLine(x.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")));

		}

		static double Function(double x) {
			return 12*x*x*x*x + 9*x*x*x - 3*x*x + 2*x - 4;
		}
	}
}
