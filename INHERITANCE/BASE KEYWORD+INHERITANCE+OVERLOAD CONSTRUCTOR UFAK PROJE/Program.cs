using System.Net.Http.Headers;

namespace Inheritance_Mini_Proje
{
	internal class Program
	{
		public static int babadankalanevsayisi;
		public static int babadankalanarabasayisi;
		public static int dededenkalanevsayisi;
		public static int dededenkalanarabasayisi;
		static void Main(string[] args)
		{

			Console.WriteLine("Dedenden Miras Var Mı ? (EVET/HAYIR)");
			Console.Write("Girdi:");
			string Cevap = Console.ReadLine();
			if (Cevap.ToUpper() == "EVET")
			{
				Console.WriteLine("DEDENDEN KALAN SADECE EV İSE 1\n ARABA İSE 2\n HEPSİ İSE 3 TUŞLAYINIZ");
				Console.Write("Girdi:");
				int Cevap2 = Convert.ToInt32(Console.ReadLine());
				if (Cevap2 == 1)
				{
					Console.WriteLine("Kaç ADET Ev Kaldı ?");
					Console.Write("Girdi:");
					dededenkalanevsayisi = Convert.ToInt32(Console.ReadLine());
					BabaSorgula();
				}
				else if (Cevap2 == 2)
				{
					Console.WriteLine("Kaç ADET Araba Kaldı ?");
					Console.Write("Girdi:");
					dededenkalanarabasayisi = Convert.ToInt32(Console.ReadLine());
				}
				else if (Cevap2 == 3)
				{
					Console.WriteLine("Kaç ADET Ev Kaldı ?");
					Console.Write("Girdi:");
					dededenkalanevsayisi = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Kaç ADET Araba Kaldı ?");
					Console.Write("Girdi:");
					dededenkalanarabasayisi = Convert.ToInt32(Console.ReadLine());
					BabaSorgula();
				}
			}
			else if (Cevap.ToUpper() == "HAYIR")
			{
				dededenkalanarabasayisi = 0;
				dededenkalanevsayisi = 0;
				BabaSorgula();
			}
			else
			{
				Console.WriteLine("Yanlış Giriş Yaptınız Lütfen Tekrar Deneyiniz !");
			}
			Console.ReadLine();
		}
		public static void BabaSorgula()
		{

			Console.WriteLine("Babadan Miras Var Mı ? (EVET/HAYIR)");
			Console.Write("Girdi:");
			string Cevap = Console.ReadLine();
			if (Cevap.ToUpper() == "EVET")
			{
				Console.WriteLine("BABANDAN KALAN SADECE EV İSE 1\n ARABA İSE 2\n HEPSİ İSE 3 TUŞLAYINIZ");
				Console.Write("Girdi:");
				int Cevap2 = Convert.ToInt32(Console.ReadLine());
				if (Cevap2 == 1)
				{
					Console.WriteLine("Kaç ADET Ev Kaldı ?");
					Console.Write("Girdi:");
					babadankalanevsayisi = Convert.ToInt32(Console.ReadLine());
				}
				else if (Cevap2 == 2)
				{
					Console.WriteLine("Kaç ADET Araba Kaldı ?");
					Console.Write("Girdi:");
					babadankalanarabasayisi = Convert.ToInt32(Console.ReadLine());
				}
				else if (Cevap2 == 3)
				{
					Console.WriteLine("Kaç ADET Ev Kaldı ?");
					Console.Write("Girdi:");
					babadankalanevsayisi = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Kaç ADET Araba Kaldı ?");
					Console.Write("Girdi:");
					babadankalanarabasayisi = Convert.ToInt32(Console.ReadLine());
				}
				else
				{
					Console.WriteLine("HATA KODU:101");
				}

			}
			else if (Cevap.ToUpper() == "HAYIR")
			{
				babadankalanarabasayisi = 0;
				babadankalanevsayisi = 0;
			}
			else
			{
				Console.WriteLine("HATA KODU 102 !");
			}
			İslemUygula();

		}
		public static void İslemUygula()
		{
			//BABADAN VE DEDEDEN BİRŞEY YOK
			if (babadankalanarabasayisi == 0 && babadankalanevsayisi == 0 && dededenkalanarabasayisi == 0 && dededenkalanevsayisi == 0)
			{
				new Father();
			}
			//BABADAN YOK DEDEDEN EV VAR ARABA YOK
			else if (babadankalanevsayisi == 0 && babadankalanevsayisi == 0 && dededenkalanevsayisi > 0 && dededenkalanarabasayisi == 0)
			{
				new Father(dededenkalanevsayisi, 0, 0, 0, 0, 0);
			}
			//BABADAN YOK DEDEDEN EV YOK ARABA VAR
			else if (babadankalanevsayisi == 0 && babadankalanarabasayisi == 0 && dededenkalanevsayisi == 0 && dededenkalanarabasayisi > 0)
			{
				new Father(dededenkalanarabasayisi, 0, 0, 0, 0, 0);
			}
			//BABADAN YOK DEDEDEN EV VAR ARABA VAR
			else if (babadankalanevsayisi == 0 && babadankalanarabasayisi == 0 && dededenkalanevsayisi > 0 && dededenkalanarabasayisi > 0)
			{
				new Father(dededenkalanarabasayisi, dededenkalanevsayisi, 0);
			}
			//BABADAN SADECE EV VE ARABA KALIRSA DEDEDEN BİRŞEY YOK
			else if (babadankalanarabasayisi > 0 && babadankalanarabasayisi > 0 && dededenkalanevsayisi == 0 && dededenkalanevsayisi == 0)
			{
				new Father(babadankalanevsayisi, babadankalanarabasayisi);
			}
			//BABADAN EV YOK ARABA VAR DEDEDEN BİRŞEY YOK
			else if (babadankalanarabasayisi > 0 && babadankalanarabasayisi == 0 && dededenkalanevsayisi == 0 && dededenkalanevsayisi == 0)
			{
				new Father(babadankalanarabasayisi);
			}
			//BABADAN EV YOK ARABA VAR DEDEDEN EV YOK ARABA VAR
			else if (babadankalanarabasayisi > 0 && babadankalanarabasayisi == 0 && dededenkalanevsayisi == 0 && dededenkalanevsayisi > 0)
			{
				new Father(babadankalanarabasayisi, dededenkalanarabasayisi, 0, 0);
			}
			//BABADAN EV YOK ARABA VAR DEDEDEN EV VAR ARABA YOK
			else if (babadankalanarabasayisi > 0 && babadankalanarabasayisi == 0 && dededenkalanevsayisi > 0 && dededenkalanevsayisi == 0)
			{
				new Father(babadankalanarabasayisi, dededenkalanevsayisi, 0, 0);
			}
			//BABADAN EV YOK ARABA VAR DEDEDEN EV VAR ARABA VAR
			else if (babadankalanarabasayisi > 0 && babadankalanarabasayisi == 0 && dededenkalanevsayisi > 0 && dededenkalanevsayisi > 0)
			{
				new Father(babadankalanarabasayisi, dededenkalanevsayisi, dededenkalanarabasayisi, 0);
			}
			//BABADAN EV VAR ARABA YOK DEDEDEN BİRŞEY YOK
			else if (babadankalanarabasayisi == 0 && babadankalanevsayisi > 0 && dededenkalanevsayisi == 0 && dededenkalanarabasayisi == 0)
			{
				new Father(babadankalanevsayisi, "bos");
			}
			//BABADAN EV VAR ARABA YOK DEDEDEN EV YOK ARABA VAR
			else if (babadankalanarabasayisi == 0 && babadankalanevsayisi > 0 && dededenkalanevsayisi == 0 && dededenkalanarabasayisi > 0)
			{
				new Father(babadankalanevsayisi, dededenkalanarabasayisi, 0);
			}
			//BABADAN EV VAR ARABA YOK DEDEDEN EV VAR ARABA YOK
			else if (babadankalanarabasayisi == 0 && babadankalanevsayisi > 0 && dededenkalanevsayisi > 0 && dededenkalanarabasayisi == 0)
			{
				new Father(babadankalanevsayisi, dededenkalanevsayisi, 0, "bos");
			}
			//BABADAN EV VAR ARABA YOK DEDEDEN EV VAR ARABA VAR
			else if (babadankalanarabasayisi == 0 && babadankalanevsayisi > 0 && dededenkalanevsayisi > 0 && dededenkalanarabasayisi > 0)
			{
				new Father(babadankalanevsayisi, dededenkalanevsayisi, dededenkalanarabasayisi, 'K');
			}
			//BABADAN EV VE ARABA VAR DEDEDENDE ARABA VE EV YOK
			else if (babadankalanarabasayisi > 0 && babadankalanevsayisi > 0 && dededenkalanarabasayisi == 0 && dededenkalanevsayisi == 0)
			{
				new Father(babadankalanevsayisi, babadankalanarabasayisi);
			}
			//BABADAN EV VE ARABA VAR DEDEDENDE ARABA YOK EV VAR
			else if (babadankalanarabasayisi > 0 && babadankalanevsayisi > 0 && dededenkalanarabasayisi == 0 && dededenkalanevsayisi > 0)
			{
				new Father(babadankalanevsayisi, babadankalanarabasayisi, dededenkalanevsayisi, false);
			}
			//BABADAN EV VE ARABA VAR DEDEDENDE ARABA VAR EV YOK
			else if (babadankalanarabasayisi > 0 && babadankalanevsayisi > 0 && dededenkalanarabasayisi > 0 && dededenkalanevsayisi == 0)
			{
				new Father(babadankalanevsayisi, babadankalanarabasayisi, dededenkalanarabasayisi, 0, 0);
			}
			//BABADAN EV VE ARABA VAR DEDEDENDE ARABA VE EV VAR
			else if (babadankalanarabasayisi > 0 && babadankalanevsayisi > 0 && dededenkalanarabasayisi > 0 && dededenkalanevsayisi > 0)
			{
				new Father(babadankalanevsayisi, babadankalanarabasayisi, dededenkalanevsayisi, dededenkalanarabasayisi, 0);
			}
			/*
			 ---------------------------------------------------EKRAN ÇIKTISI-------------------------------------------------------
			Dedenden Miras Var Mı ? (EVET/HAYIR)
            Girdi:evet
            DEDENDEN KALAN SADECE EV İSE 1
                                  ARABA İSE 2
                                  HEPSİ İSE 3 TUŞLAYINIZ
            Girdi:3
            Kaç ADET Ev Kaldı ?
            Girdi:10
            Kaç ADET Araba Kaldı ?
            Girdi:15
            Babadan Miras Var Mı ? (EVET/HAYIR)
            Girdi:evet
            BABANDAN KALAN SADECE EV İSE 1
                                  ARABA İSE 2
                                  HEPSİ İSE 3 TUŞLAYINIZ
           Girdi:3
           Kaç ADET Ev Kaldı ?
           Girdi:20
           Kaç ADET Araba Kaldı ?
           Girdi:25
           Dededen Kalan Ev Sayisi:10
           Dededen Kalan Araba Sayisi:15
           Babadan Kalan Ev Sayisi:20
           Babadan Kalan Araba Sayisi:25
			 */
		}
	}
}