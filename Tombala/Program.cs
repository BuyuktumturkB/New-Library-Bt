using System;

namespace Tombala
{
	class Program
	{
		public static void Tombala()
		{
			int cinkop1=0;
			int cinkop2 = 0;
			int cinkop3=0;
			int inputoyuncu;
			Random tombala = new Random();
			int kura = tombala.Next(40);
			string soru;
			while (cinkop1!=3 || cinkop2 != 3 || cinkop3 != 3)
			{
				Console.WriteLine(kura);
				Console.WriteLine("Cinko var mi");
				soru = Console.ReadLine();
				if (soru == "Evet")
				{
					Console.WriteLine("Cinko yapan oyuncuyu giriniz");
					inputoyuncu = Convert.ToInt32(Console.ReadLine());
					if (inputoyuncu == 1)
					{
						cinkop1++;

					}
					else if (inputoyuncu == 2)
					{
						cinkop2++;
					}
					else if (inputoyuncu == 1)
					{
						cinkop3++;
					}
					
				}
				else if (soru== "Hayir")
				{
					cinkop1=cinkop1+0;
					cinkop2 =cinkop2+0;
					cinkop3 = cinkop3 + 0;
				}

			}
			if (cinkop1 == 3)
			{
				Console.WriteLine("Tebrikler 1. Oyuncu kazandi");

			}
			else if (cinkop2 == 3)
			{
				Console.WriteLine("Tebrikler 2. Oyuncu kazandi");

			}
			else 
			{
				Console.WriteLine("Tebrikler 3. Oyuncu kazandi");
			}

		}
		static void Main(string[] args)
		{
			Tombala();

		}
	}
}
