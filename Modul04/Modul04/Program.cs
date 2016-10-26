cd цд using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string[,] table = {
				{ "Иван", 	"Георгирв", 	"19" },
				{ "Васил", 	"Иванов", 		"23" },
				{ "Милен", 	"Георгирв", 	"58" },
				{ "Цветан", 	"Бориславов",	"14" },
				{ "Гергана", "Василева", 	"25" },
				{ "Ивана", 	"Христова", 	"21" },
			};
			//антетка на таблица
			Console.WriteLine ("Име".PadRight (12) + "Фамилия".PadRight (12) + "Години".PadRight (12));
			Console.WriteLine ("==================");


			// Тяло на таблица

			// Пример с for
//			for (int i=0; i < table.Length/3; i++ )
//			{
//				for (int j=0; j<3; j++)
//				{
//			Console.Write (table [i, j].PadRight (12));
//				}
//				Console.WriteLine ();

//			// Пример с while
//			int i=0;
//				while (i<table.Length/3)
//				{
//					Console.WriteLine (
//					table[i, 0].PadRight(12) + 
//					table[i, 1].PadRight(12) + 
//					table[i, 2].PadRight(12));
//				i++;
//				}

			//Пример с do...while
			int i = 0;
			do {
				Console.WriteLine (table [i, 0].PadRight (12) + table [i, 1].PadRight (12) +
				table [i, 2].PadRight (12));
				i++;
			} while(i < table.Length / 3);
		}
		}
	}   


