using System;

namespace BoolExplore2
{
	class MainClass
	{
		public static void Main ()
		{
			int[] i = new int[] { 4, 3, 2 };

			int ui = 0; 
			string input = "0";

			Console.Write ("Моля въведете индекс: ");
			input = Console.ReadLine ();
			bool check01 = int.TryParse (input, out ui);

			try
			{
				Console.WriteLine ("Елемент " + ui.ToString () + " от масива е: ");
				Console.WriteLine (i [ui-1]);

			}catch{
				Console.WriteLine ("Недефиниран елемент");
			}

//			Използване на условно присвояване

//			ui = (ui <= i.Length ) ? ui : 3;
//			ui = (ui > 0) ? ui : 1;

//			Използване на Switch
//	
//			switch (ui) {
//			case 1:  
//				{
//					Console.WriteLine ("1-ви елемент от масива");
//					Console.WriteLine (i [ui-1]);
//					break;
//				}
//			
//			case 2:
//				{
//					Console.WriteLine ("1-ви елемент от масива");
//					Console.WriteLine (i [ui-1]);
//					break;
//				}
//			
//			case 3:
//				{
//					Console.WriteLine ("1-ви елемент от масива");
//					Console.WriteLine (i [ui-1]);
//					break;
//				}
//
//			default:
//				{
//					Console.WriteLine ("В масива няма ст-ст за този индекс.\nОпитайте с индекс между 1 и 3.\n\n");
//					break;
				}


//			if (check01)
//			{ Console.WriteLine (i [ui - 1]);
//		}
//		}
	}
}
