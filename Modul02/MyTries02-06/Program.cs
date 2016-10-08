using System;

namespace MyTries0206
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		
			int[] zada1 = new int [20];
			zada1 [0] = 5*0;
			zada1 [1] = 5*1;
			zada1 [2] = 5*2;
			zada1 [3] = 5*3;
			zada1 [4] = 5*4;
			zada1 [5] = 5*5;
			zada1 [6] = 5*6;
			zada1 [7] = 5*7;

			Console.WriteLine ("елем на масива: " + zada1[0] + "," + zada1[1] + "," + zada1[2] + "," + zada1[3] + "," + zada1[4] + "," + zada1[5] + "," + zada1[6] + "\n\n");

			string[] niki = "1,2,3,4,5,6,7,8,9".Split (',');
			Console.WriteLine("Броят на масива:\n" + "1,2,3,4,5,6,7,8,9\n\ne: " + niki.Length + "\n\n");

			string list1 = string.Join ("--", niki);
			Console.WriteLine ("Новият стринг е:\n" + list1 + "\n\n");

			string[] week = "M, T, W, T, F, S, S".Split ('-');
			Console.WriteLine ("Дните от седмицата са:\n" + "M, T, W, T, F, S, S" +"\n\n");


			int[,] a = new int [3,3]
			{{1,2,3}, {4,5,6}, {7,8,9}};
			Console.WriteLine(a[0,0]+" "+a[0,1]+" "+a[0,2]);
			Console.WriteLine(a[1,0]+" "+a[1,1]+" "+a[1,2]);
			Console.WriteLine(a[2,0]+" "+a[2,1]+" "+a[2,2]);
		}
	}
}