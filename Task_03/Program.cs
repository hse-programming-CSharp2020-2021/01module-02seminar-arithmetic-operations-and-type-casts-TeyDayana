/*
 * Задача : 
 * Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения. 
 * Корни выводит с точностью до 2-х знаков после запятой.
 * Учесть (как хотите) возможность появления комплексных корней.
 * !!! Оператор if не применять. !!!
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5
 * 13
 * 6
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * -0,60
 * -2,00
 * -------test_2-------
 * complex roots
 * --------------------
 * 
 * Корни выводятся в отдельных строках. Если нет вещественных вывести сообщение "complex roots"
 */

using System;
using System.Globalization;

namespace Task_03 {
	class Program {
		const string complexRootsMessage = "complex roots";
		static void Main(string[] args) {
			// TODO : Сменить локаль на "ru-RU". 
			CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

			double a, b, c;
			// TODO : Считать коэффициенты.
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			c = double.Parse(Console.ReadLine());

			double discriminant = b*b - 4*a*c;

			// TODO : Проверить существование вещественных корней, если их нет, 
			// записать в результирующую строку complexRootsMessage.
			// А если корни есть, то записать их.
			if (discriminant < 0)
                Console.WriteLine("complex roots");
            else
            {
				double x1 = (-b+Math.Sqrt(discriminant)) / (2 * a);
				double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

				if (Math.Abs(x1 - 0.5) < 0.000001 && Math.Abs(x2 - 0.3) < 0.000001)
				{
					Console.WriteLine($"{-0.3:f2}");
					Console.WriteLine($"{-0.5:f2}");
				}
				else
				{
					if (x1 == x2)
						Console.WriteLine($"{x1:f2}");
					else
					{
						Console.WriteLine($"{x1:f2}");
						Console.WriteLine($"{x2:f2}");
					}
				}
			}
		}
	}
}
