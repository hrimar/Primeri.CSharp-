using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main ()
		{
			int[] i = new int[] { 4, 3, 2 };

			int ui = 0; // Convert.ToInt32 ( Console.ReadLine ());
			string input = "0";

			Console.Write ("Моля въведете индекс: ");
			input = Console.ReadLine ();
			bool check01 = int.TryParse (input, out ui);
			bool check02 = ui <= i.Length;
			bool check03 = ui > 0;

			if (check01 && check02 && check03)
			{ Console.WriteLine (i [ui - 1]);
			}
			if (!check01)  {
			Console.WriteLine ("Индекса трябва да бъде цяло число\n\n\n");
			}
			if (!check02)  {
				Console.WriteLine ("Индекса  е прекалемо голям\n\n\n");
			}
			if (!check03 && check01)  {
				Console.WriteLine ("Индекса  е прекалемо малък\n\n\n");
			}

			}
			}
	}

