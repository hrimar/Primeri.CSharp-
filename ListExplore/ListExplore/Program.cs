using System;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string userinput="";

			//Потребителски шход
			do {
				Console.WriteLine("? ");
				userinput = Console.ReadLine ();
			} while(userinput != "exit");
		}
	}
}
