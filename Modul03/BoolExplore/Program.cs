using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] i = new int[] { 4, 3, 2 };

			int ui = Convert.ToInt32 ( Console.ReadLine ());


//			bool check01 = ui <= i.Length;
//			bool check02 = ui > 0;
//
//			bool exp01 = check01 && check02;	//Логическо и "§§"
//			bool exp02 = check01 || check02;	//Логическо или "||"
//			bool exp03 = !check01;			// Отрицание "!"
//
//			Console.WriteLine ("Логическо И:" + exp01.ToString ());
//			Console.WriteLine ("Логическо ИЛИ:" + exp02.ToString ());
//			Console.WriteLine ("Отрицание на " + check01.ToString () + ": " + exp03);

			//Console.WriteLine (check01);
			//Console.WriteLine (check02);

			if (ui > 0 && ui <= i.Length) {
				Console.WriteLine (i [ui - 1]);
			} else 
				if (ui > i.Length) {
					Console.WriteLine ("Индекса е прекалемо голям\n\n\n");
				}
				if (ui <= 0) {
					Console.WriteLine ("Индекса е прекалемо малък\n\n\n");
				}
			}
	}
}

