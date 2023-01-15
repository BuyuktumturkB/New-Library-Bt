using System;

namespace AlanHesaplayıcı
{
	class Program
	{
		public static double pi = 3.14;
		public static void Kare()
		{
			Console.WriteLine("Lütfen Yaptırmak istediğiniz işlemi seçiniz");
			Console.WriteLine("1: Alan" + "2 Çevre Hesaplama");
			int secim = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Lütfen Kenar Uzunluğunu Giriniz");
			int kenar = Convert.ToInt32(Console.ReadLine());
			int sonuc;

			if (secim == 1)
			{
				sonuc = kenar * kenar;
				Console.WriteLine("Alan"+sonuc+"cm^2");

			}
			else if (secim == 2)
			{
				sonuc = kenar * 2;
				Console.WriteLine("Çevre= " + sonuc + "cm");
			}


		}
		public static void Daire()
		{
			int   yarıcap, secim;
			double sonuc;

			Console.WriteLine("Lütfen Yaptırmak İstediğniz işlemi Seciniz");
			Console.WriteLine("1. Alan 2. Çevre 3. Hacim");
			secim = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Lütfen Yarıçap Değerini Giriniz");
			yarıcap = Convert.ToInt32(Console.ReadLine());

			if (secim == 1)
			{
				sonuc = yarıcap * yarıcap * pi;
				Console.WriteLine("Alan= " + sonuc + "cm^2");

			}
			else if (secim == 2)
			{
				sonuc = 2 * yarıcap * pi;
				Console.WriteLine("Çevre = " + sonuc + "cm");
			}
			else if (secim == 3)
			{
				sonuc = (4 / 3) * pi * MathF.Pow( 3, yarıcap);
				Console.WriteLine("Hacim= " + sonuc + " cm^3");
			}

		}
		public static void Dikdörtgen()
		{
			int uzunkenar, kısakenar, yükseklik, sonuc,secim;
			Console.WriteLine("Lütfen Yaptırmak İstediğniz işlemi Seciniz");
			Console.WriteLine("1. Alan 2. Çevre 3. Hacim");
			secim = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Lütfen Uzun Kenar Giriniz");
			uzunkenar = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Lütfen Kısa Kenar Giriniz");
			kısakenar = Convert.ToInt32(Console.ReadLine());
			if (secim == 1)
			{
				sonuc =  (uzunkenar * kısakenar);
				Console.WriteLine("Alan= " + sonuc + "cm^2");

			}
			else if (secim == 2)
			{
				sonuc = 2 * (uzunkenar+kısakenar);
				Console.WriteLine("Çevre = " + sonuc + "cm");
			}
			else if (secim == 3)
			{
				Console.WriteLine("Lütfen Yükseklik Giriniz");
				yükseklik = Convert.ToInt32(Console.ReadLine());
				sonuc = uzunkenar * kısakenar * yükseklik;
				Console.WriteLine("Hacim= " + sonuc + " cm^3");




			}
		static void Main(string[] args)
		{
			Console.WriteLine("Lütfen şekil seciniz");
			Console.WriteLine("1.Kare");
			Console.WriteLine("2.Daire");
			int islem = Convert.ToInt32(Console.ReadLine());
			if (islem == 1)
			{
				Kare();
			}
			else if (islem == 2)
			{
				Daire();
			}
			else if (islem == 3)
				{
					Dikdörtgen();
				}

		}
	}
}
