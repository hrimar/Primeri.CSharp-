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
                Console.Write("$ "); usercommand = Console.ReadLine();
                if (usercommand.Contains("cmd1")) cmd1(usercommand);    // тогава ще извика метода cmd1
                if (usercommand.Contains("cmd2")) Console.WriteLine(cmd2(usercommand));
                if (usercommand.Contains("cmd3"))
                {
                    double a = 0;
                    if (cmd3(usercommand, out a))
                    {
                        Console.WriteLine("a . a= " + a.ToString());
                    }
                    else
                    { Console.WriteLine("Командата не е въведена коректно"); }
                }

                if (usercommand.Contains("cmd4"))
                {
                    double t = 5, c=-2;
                    if(cmd4(ref t))
                    {
                        Console.WriteLine(t);
                    }
                    if (cmd4(ref c))
                    {
                        Console.WriteLine(0);
                    }
                }
            }
            while (usercommand != "exit");
		}

        // Само да се изпълнят
       
        public static void cmd1(string input )  // Метод "cmd1" за качване на 2-ра степен (5^2):
		{
			try {
				double temp = 0.0;
				if (double.TryParse (input.Split (' ') [1], out temp))
				{
					Console.WriteLine ("\nРезултата от " + temp.ToString() + "^2: " + (temp * temp).ToString());
				}
                
				} catch {
				}
		}

		public static int cmd2(string input) // Правим нов метод "cmd2"за вдигане на 3-та степен
		{
				
			int temp = 0;

            if (int.TryParse(input.Split(' ')[1], out temp))
            {
                temp = temp * temp * temp;
            }
            return temp;
		}

        // Да върнат параметри
       
        public static bool cmd3(string input, out double i) // cmd3 45 -> 45*45 с проверка з апарсване
        {
            try
            {
                string p = input.Split(' ')[1]; // ако е въведено cmd3  ili cmd3  43 ili cmd fdfs - ще изписва "Команд не коректна"
                double _p = 0;
                if (double.TryParse(p, out _p))
                {
                    i = _p*_p;
                    return true;
                }
            } catch
            {               
            }
            i = 0;
            return false;
        }

        public static bool cmd4(ref double i)
        {
            //if(i>0)
            //{
            //    i = i * i;
            //    return true;
            //}
            //return false;

            double temp = i;
            i = i * i;

            return (temp>0); // това е аналог на горното т.е ще връща резулт само ако i>0
        }

    }
} 
