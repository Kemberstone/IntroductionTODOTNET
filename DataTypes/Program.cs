using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		const string delimiter = "\n------------------------------------\n";
		static void Main(string[] args)
		{
			Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обвертка Boolean;");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));
			Console.WriteLine(delimiter);

			Console.WriteLine($@"тип данных char занимает {sizeof(char)} Байт памяти, и принимает значение в диапозоне от {(int)char.MinValue} до {(int)char.MaxValue}. 
            Класс-обвертка - {typeof(char)}");
			Console.WriteLine(delimiter);

			Console.WriteLine(@"RAW - строка игнорируется все специальные символы и escape - последовательности \t\n, 
            т.е. воспринимается как есть");
			Console.WriteLine(delimiter);

			Console.WriteLine($@"byte занимает {sizeof(byte)} Байт памяти,
            и принимает значение в диапозоне от {byte.MinValue} до {byte.MaxValue}, 
            класс -обвертка{typeof(byte)}");
			Console.WriteLine(delimiter);

			Console.WriteLine($@"sbyte занимает {sizeof(sbyte)} Байт памяти,
            и принимает значение в диапозоне от {sbyte.MinValue} до {sbyte.MaxValue}, 
            класс-обвертка{typeof(sbyte)}");
			Console.WriteLine(delimiter);

			Console.WriteLine($@"float занимает {sizeof(float) } байт: ");
			Console.WriteLine(delimiter);

			Console.WriteLine($@"decimal занимает {sizeof(decimal)} байт: ");
			Console.WriteLine(args);
			Console.WriteLine(delimiter);

			Console.WriteLine(5.0.GetType());
			Console.WriteLine(delimiter);



		}
	}
}
