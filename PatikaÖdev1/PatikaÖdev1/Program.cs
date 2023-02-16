using System;

namespace PatikaÖdev1
{
	class Program
	{
		static void Soru1()
		{
			int counter;
			Console.Write("Pozitif bir sayi giriniz");
			counter = Convert.ToInt32(Console.ReadLine());

			while (counter > 0)
			{
				int sayı;
				Console.WriteLine("Lutfen Sayi Giriniz");
				sayı = Convert.ToInt32(Console.ReadLine());
				if (sayı % 2 == 0)
				{
					Console.Write(sayı);
				}
				counter--;

			}

		}

		static void Soru2()
		{
			int n, m,sayi;
			int [] grup = new int[m];
			Console.WriteLine("Lütfen Birinci Sayiyi Gir");
			n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("İkinci Sayiyi Gir");
			m = Convert.ToInt32(Console.ReadLine());
			int i = 0;
			while (n != 0)
			{
				Console.WriteLine("Sayi Giriniz");
				sayi = Convert.ToInt32(Console.ReadLine());
				if (sayi % m == 0)
				{
					grup[i] = sayi;
					i++;
					n--;
				}
				else
				{
					n--;
					i++;
				}
			}
			Console.Write(grup);
		}

		static void Soru3()
		{
			Console.WriteLine("Lütfen bir sayi giriniz");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Lütfen " + n + "kadar kelime giriniz");
			string kelime;
			while (n > 0)
			{
				kelime = Console.ReadLine();
				Console.Write(kelime);
				n--;


			}
		}
		static void Main(string[] args)
		{
			//Soru1();
			Soru3();
		}
	}
}
