using System;

namespace ReadFromComandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на входни параметри
			Console.Write ("Моля въведете а: ");
			b = Convert.ToInt32 ( Console.ReadLine () );

			//Печат на резултат
			Console.WriteLine ("Резултата а+b е " +(a + b).ToString () + "\n\n\n");
		}
	}
}
