using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class Program
	{
		static int x = 10, y = 10; //изначальная позиция
		const char ICON = '@';//Барбос

		static void Main()
		{
			Console.CursorVisible = false;//вырубаем мигающий курсор

			while (true)
			{
				DrawIcon();//отрисовываем иконку
				var key = Console.ReadKey(true).Key;//чтение нажатой клавиши из консоли
				ClearIcon();//удаляем иконку

				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W:
						if (y > 0) y--;
						break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S:
						if (y < Console.WindowHeight - 1) y++;
						break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A:
						if (x > 0) x--;
						break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D:
						if (x < Console.WindowWidth - 1) x++;
						break;
					case ConsoleKey.Escape:
						return;
				}
			}
		}

		static void DrawIcon()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(ICON);
		}

		static void ClearIcon()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(' ');
		}
	}
}
