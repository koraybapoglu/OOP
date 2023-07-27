using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Static_Constructor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			void Getir(MyClass uye)
			{
				Console.WriteLine("ÜYE ADI:" + " " + uye.UyeAdi);
				Console.WriteLine("ÜYE SOYADI:" + " " + uye.UyeSoyadi);
				Console.WriteLine("ÜYE YAŞI:" + " " + uye.UyeYasi);
				Console.WriteLine("*******************************************");
			}
			MyClass uye1 = new MyClass();
			uye1.UyeAdi = "Koray";
			uye1.UyeSoyadi = "Bapoğlu";
			uye1.UyeYasi = 22;
			Console.WriteLine("İLK Üye Oluşturuldu !");
			Getir(uye1);
			MyClass uye2 = new MyClass();
			uye2.UyeAdi = "DenemeUye";
			uye2.UyeSoyadi = "DenemeUyeSoyadi";
			uye2.UyeYasi = 33;
			Getir(uye2);
			Console.WriteLine("Üye Oluşturuldu !");
			Console.ReadLine();
			//--------------------------------------EKRAN ÇIKTISI------------------------------------------------
			/* İlk Üye Oluşturuluyor.
			   Üye Oluşturuluyor.
			   İLK Üye Oluşturuldu !
			   ÜYE ADI: Koray
			   ÜYE SOYADI: Bapoğlu
			   ÜYE YAŞI: 22
			   *******************************************
			   Üye Oluşturuluyor.
			   ÜYE ADI: DenemeUye
			   ÜYE SOYADI: DenemeUyeSoyadi
			   ÜYE YAŞI: 33
			   *******************************************
			   Üye Oluşturuldu !
			   */
		}
	}
}