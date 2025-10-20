//#define CONSOLE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionTODOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CONSOLE
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Hello .NET\t");
            Console.WriteLine();
            Console.Title = "Introduction to .NET";
            Console.Beep(37, 2000);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("SetCursorPosition");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("Another Position");
            Console.ResetColor();
            Console. 
#endif

			//Console.Write("Введите ваше имя: ");
			//string firstName = Console.ReadLine();

			//Console.Write("Введите вашу фамилию: ");
			//string lastName = Console.ReadLine();

			//Console.Write("Введите ваш возраст: ");
			//int age = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine(lastName + " " + firstName + " " + age); //конкатенация строк
			//Console.WriteLine(String.Format("{0} {1} {2}", lastName, firstName, age)); //Форматирование строк
			//Console.WriteLine($"{lastName} {firstName} {age}");

			Console.Write("Введите число: ");
			int size = int.Parse(Console.ReadLine());

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 1; i <= size; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for(int i = size; i >= 1; i--)
            {
				for (int j = 1; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 0; i < size; i++)
			{
				for (int space = 0; space < i; space++)
				{
					Console.Write("  ");
				}
				for (int star = 0; star < size - i; star++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 1; i <= size; i++)
			{
				for (int space = 1; space <= size - i; space++)
				{
					Console.Write("  ");
				}
				for (int star = 1; star <= i; star++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 0; i < size; i++)//верхняя половина
			{
				for (int space = 0; space < size - i - 1; space++)//пробелы слева
				{
					Console.Write(" ");
				}

				Console.Write("/");//левый слеш

				for (int space = 0; space < i * 2; space++)//пробелы внутри
				{
					Console.Write(" ");
				}

				Console.Write("\\");//правый слеш
				Console.WriteLine();
			}

			for (int i = size - 1; i >= 0; i--)//нижняя половина
			{
				for (int space = 0; space < size - i - 1; space++)//пробелы слева
				{
					Console.Write(" ");
				}

				Console.Write("\\");//левый обратный слеш

				for (int space = 0; space < i * 2; space++)//пробелы внутри
				{
					Console.Write(" ");
				}
				
				Console.Write("/");//правый слеш
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if ((i + j) % 2 == 0)
					{
						Console.Write("+ ");
					}
					else
					{
						Console.Write("- ");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.Write("Шахматная доска.\nВведите число: ");
			Console.WriteLine();
			int boardSize = int.Parse(Console.ReadLine());
			for (int cell_i = 0; cell_i < boardSize; cell_i++)  // строки клеток
			{
				for (int line_in_cell = 0; line_in_cell < boardSize; line_in_cell++)//внутренние циклы для строк внутри одной клетки
				{
					for (int cell_j = 0; cell_j < boardSize; cell_j++)//цикл по столбцам клеток
					{
						if ((cell_i + cell_j) % 2 == 0)
						{
							for (int k = 0; k < boardSize; k++)//печатаем n звездочек подряд для "черной" клетки
								Console.Write("* ");
						}
						else
						{
							for (int k = 0; k < boardSize; k++)//печатаем n пробелов для "белой" клетки
								Console.Write("  ");
						}
					}
					Console.WriteLine(); //переход на новую строку после каждой линии клеток
				}
			}
		}
    }
}
