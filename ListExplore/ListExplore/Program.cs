using System;
using System.Collections.Generic;

namespace ListExplore

{
	class MainClass
	{
		public static void Main ()
		{  
			//Дефиниции
			string userinput="";
			List<int> list = new List<int> ();

			list.Add (5);
			list.Add (3);
			list.Add (9);

			//Потребителски шход
			do {
				Console.WriteLine("? ");
				userinput = Console.ReadLine ();

				//Добавяне на стойности

				//Преглед на List
				if (userinput.Contains ("show"))
				{
					Console.Write ("list: ");
					for (int i=0; i<list.Count; i++)
					{
						Console.Write (list[i] );
						if (i!= list.Count -1) Console.Write (", ");
					}
						Console.WriteLine ();	
				}
				//Размер на List
				
			} while(userinput != "exit");  
		}
	}}
