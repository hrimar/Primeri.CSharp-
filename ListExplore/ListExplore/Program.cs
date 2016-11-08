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

			//Потребителски вход
			do {
				Console.Write("? ");
				userinput = Console.ReadLine ();

				//Добавяне на стойности
				// адд <int>   - да се вавеждат ст-ти от този тип

				if (userinput.ToLower().Contains("add"))  // с ToLower - даваме възможност да се пише и с главни букви
				{
					try
					{
						int add=0;
						if ( int.TryParse (userinput.Split (' ')[1], out add))
						{         // ако потребителя въведе add, Add или ADD, пауза и qисло, то щесе добави към систа
								 // но ако напише add и повече паузи, няма да се добави
							list.Add(add);
						}
						Console.WriteLine("");
					}catch {}
				} 
					
				
				//Преглед на List
					if (userinput.ToLower().Contains ("show"))
				{
					Console.Write ("Соисък: ");

					foreach (int value in list) //заменяме цикъла for  с този, който работи с променливата за обход value
					{
						Console.Write(value.ToString() + ", ");
					}

//					for (int i=0; i<list.Count; i++)
//					{
//						Console.Write (list[i] );
//						if (i!= list.Count -1) Console.Write (", ");
//					}
						Console.WriteLine ("\n");	
				}
				//Размер на List
					if (userinput.ToLower().Contains ("size"))
					{
						Console.WriteLine("размер на списъка: " + list.Count.ToString () + "\n");
					}
			} while(userinput != "exit");  
		}
	}
}

