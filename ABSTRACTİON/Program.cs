using System;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class ConsoleApp10
{
	public static void Main()
	{
		//BURADA YAPTIĞIMIZ İŞLEM ABSTRACTİON(SOYUTLAMA) İŞLEMİDİR.
		Uye uye = new Uye(); //NORMALDE BURADA OLUŞTURDUĞUMUZ UYE NESNESİ ÜZERİNDENDE UYEKAYIT VE UYEKAYITONAYLA METHODLARINA ULAŞABİLİYORUZ.FAKAT ARADAKİ TEK FARK DİĞER GEREKSİZ OLAN O İŞLEM İÇİN KULLANMAYACAĞIMIZ UYESİL VE UYEGUNCELLE METHODLARINADA ERİŞEBİLMEMİZ.POLİMORFİZMİN YANİ ÇOK BİÇİMLİLİĞİN BURADA BİZE TANIMIŞ OLDUĞU YARARLARDAN FAYDALANARAK IUYEGİRİSADI ADI ALTINDA INTERFACE OLUŞTURUYORUZ VE BUNU UYE CLASS'INDA IMPLEMENT ETTİRİYORUZ.
		IUyeGiris uyegirisislemi = uye; //IMPLEMENT İŞLEMİNDEN SONRA INTERFACE'İ REFERANS GÖSTEREREK uyegirisislemi adı altında bir nesne üretiyoruz.OLUŞTURDUĞUMUZ NESNE SAYESİNDE ULAŞABİLDİĞİMİZ SADECE UYEKAYIT VE UYEKAYITONAYLA İŞLEMLERİ OLUYOR. BURADA YAPTIĞIMIZ İŞLEM POLİFORMİZM'DİR.
		uyegirisislemi.UyeKayit();
		uyegirisislemi.UyeKayitOnayla();
		Console.ReadLine();
	}
	interface IUyeGiris 
	{
		void UyeKayit();
		void UyeKayitOnayla();
	}
	class Uye : IUyeGiris
	{
		public void UyeKayit()
		{
		}

		public void UyeKayitOnayla()
		{
		}
		public void UyeSil() 
		{

		}
		public void UyeGuncelle() 
		{

		}
	}
}
