using System;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Linq;
using ConsoleApp10;
using System.Security.Cryptography.X509Certificates;

public class WakeOnLan
{
	public static void Main()
	{
		bool tekrarDeneme = true;
		while (tekrarDeneme)
		{
			Console.WriteLine("Lütfen Cinsiyetinizi Seçiniz:\n Erkek ise 1,Kadın ise 2");
			int secim = Convert.ToInt32(Console.ReadLine());
			string adi;
			string soyadi;
			int yasi;

			switch (secim)
			{
				case 1:
					sorgula();
					Insan insan = new Erkek(adi, soyadi, yasi); //Burada oluşturduğumuz insan nesnesi çok biçimlilik kullanarak hem bir Erkek hemde bir insandır.
					yazdir(insan);
					break;
				case 2:
					sorgula();
					insan = new Kadin(adi, soyadi, yasi); //Burada oluşturduğumuz insan nesnesi çok biçimlilik kullanarak hem bir Kadın hemde bir insandır.
					yazdir(insan);
					break;
				default:
					Console.WriteLine("Hata Kodu 101, Lütfen geçerli bir seçim yapınız.");
					break;
			}

			Console.WriteLine("Tekrar denemek istiyor musunuz? (Evet için 'E' veya 'e' girin, Hayır için herhangi bir tuşa basın)");
			string tekrarSecim = Console.ReadLine();
			tekrarDeneme = (tekrarSecim.ToLower() == "e");
			void sorgula()
			{
				Console.WriteLine("Ad Giriniz:");
				adi = Console.ReadLine();
				Console.WriteLine("Soyad Giriniz:");
				soyadi = Console.ReadLine();
				Console.WriteLine("Yaş Giriniz:");
				yasi = Convert.ToInt32(Console.ReadLine());
			}
			void yazdir(Insan ınsan)
			{
				Console.WriteLine("Adiniz:" + ınsan.Adi);
				Console.WriteLine("Soyadiniz:" + ınsan.Soyadi);
				Console.WriteLine("Cinsiyetiniz:" + ınsan.Cinsiyet);
				Console.WriteLine("Yaşınız:" + ınsan.Yasi);
				Console.ReadLine();
			}
		}
	}
	/* -------------------------------------------------------------Ekran Çıktısı-------------------------------------------------------------
	 Lütfen Cinsiyetinizi Seçiniz:
     Erkek ise 1,Kadın ise 2
     1
     Ad Giriniz:
     Koray
     Soyad Giriniz:
     Bapoğlu
     Yaş Giriniz:
     22
     Ben Bir Erkeğim
     Adiniz:Koray
     Soyadiniz:Bapoğlu
     Cinsiyetiniz:Erkek
     Yaşınız:22

     Tekrar denemek istiyor musunuz? (Evet için 'E' veya 'e' girin, Hayır için herhangi bir tuşa basın)
     e
     Lütfen Cinsiyetinizi Seçiniz:
     Erkek ise 1,Kadın ise 2
     2
     Ad Giriniz:
     Selin
     Soyad Giriniz:
     Yürek
     Yaş Giriniz:
     25
     Ben bir Kadınım.
     Adiniz:Selin
     Soyadiniz:Yürek
     Cinsiyetiniz:Kadın
     Yaşınız:25
	  */
}
