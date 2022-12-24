using System;
using System.IO;


namespace DeHontCalculator
{
	class Program
	{
		
		static void Secim()
		{
			int Partisayisi;
			int delege;
			int bolum = 2;
			int partia = 0;
			int partib = 0;
			int partic = 0;
			int partid = 0;
			Console.WriteLine("Lutfen Parti Sayisini Giriniz");
			Partisayisi = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Lutfen Delege Sayisini Giriniz");
			delege = Convert.ToInt32(Console.ReadLine());
			double [] oysayisi = new double[Partisayisi];
			for (int i = 0; i < oysayisi.Length; i++)
			{
				Console.WriteLine(oysayisi[i] + "icin oy sayısını giriniz");
				oysayisi[i] = Convert.ToDouble(Console.ReadLine());
			}
			while (delege > 0)
			{
				
				if (oysayisi[0] > oysayisi[1] && oysayisi[0] > oysayisi[2] && oysayisi[0]>oysayisi[3])
				{
					oysayisi[0] = oysayisi[0] / bolum;
					Console.WriteLine("1. Parti Yeni Oy Oranı= " + oysayisi[0]);
					bolum++;
					partia++;
					Console.WriteLine("1. parti Delege" + partia);
					delege--;
					Console.WriteLine(delege + "kalan vekil");
				}
				else if (oysayisi[1] > oysayisi[0] && oysayisi[1] > oysayisi[2] && oysayisi[1] > oysayisi[3])
				{
					oysayisi[1] = oysayisi[1] / bolum;
					Console.WriteLine("2. parti Yeni Oy Oranı= " + oysayisi[1]);
					bolum++;
					partib++;
					Console.WriteLine("2. parti Delege" + partib);
					delege--;
				}
				else if (oysayisi[2] > oysayisi[0] && oysayisi[2] > oysayisi[1] && oysayisi[2] > oysayisi[3])
				{
					oysayisi[2] = oysayisi[2] / bolum;
					Console.WriteLine("3. parti Yeni Oy Oranı= " + oysayisi[2]);
					bolum++;
					partib++;
					Console.WriteLine("3. parti Delege" + partic);
					delege--;
				}
				else if (oysayisi[3] > oysayisi[0] && oysayisi[3] > oysayisi[1] && oysayisi[3] > oysayisi[2])
				{
					oysayisi[3] = oysayisi[3] / bolum;
					Console.WriteLine(" 4. Parti Yeni Oy Oranı= " + oysayisi[3]);
					bolum++;
					partid++;
					Console.WriteLine("4. parti Delege" + partid);
					delege--;
				}


			}
			Console.WriteLine("Parti 1 : " + partia + "milletvekili");
			Console.WriteLine("Parti 2 : " + partib + "milletvekili");
			Console.WriteLine("Parti 3 : " + partic + "milletvekili");
			Console.WriteLine("Parti 4 : " + partid + "milletvekili");

		}
		static void Main(string[] args)
		{
			Secim();
		}
	}
}
