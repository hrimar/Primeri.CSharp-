using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Дефиниции
			string usercommand = "";

			//Потребителски команди (usercommand);
			do
			{
				Console.Write ("$");	usercommand = Console.ReadLine();
				if (usercommand.Contains("cmd1"))  cmd1 (usercommand);
				if (usercommand.Contains("cmd2"))  Console.WriteLine(cmd2 (usercommand));
			} 
					while (usercommand != "exit");
		}

		// Само да се изпълнят
		public static void cmd1(string input )  // Метод "cmd1" за качване на 2-ра степен (5^2):
		{
			try {
				double temp = 0;
				if (double.TryParse (input.Split (' ') [1], out temp))
				{
					Console.WriteLine ("\nРезултата от " + temp.ToString () + "^2: " + (temp * temp).ToString ());
				}
				} catch {
				}
		}

		public static int cmd2 (string input) // Правим ноов метод "cmd2"за вдигане на 3-та степен
		{
				
			int temp = 0;
			if (int.TryParse (input.Split (' ') [1], out temp))
			{
				temp = temp * temp * temp;
			}
			return temp;
		}

		// Да върнат параметри

	}
} 
