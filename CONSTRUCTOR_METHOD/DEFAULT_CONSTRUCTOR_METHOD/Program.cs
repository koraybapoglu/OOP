namespace DefaultConstructor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UyeBilgileri uyeBilgileri = new UyeBilgileri(); //'()' kullanarak nesnenin yapıcı(constructor) methodunu çağırdım fakat constructor yok !
			uyeBilgileri.UyeAdi = "Koray";
			uyeBilgileri.UyeSoyadi = "Bapoğlu";
			uyeBilgileri.UyeYasi = 22;
			uyeBilgileri.UyeCinsiyet = "Erkek";
			Console.WriteLine("Adı:" + uyeBilgileri.UyeAdi);
			Console.WriteLine("Soyadı:" + uyeBilgileri.UyeSoyadi);
			Console.WriteLine("Yaşı:" + uyeBilgileri.UyeYasi);
			Console.WriteLine("Cinsiyeti:" + uyeBilgileri.UyeCinsiyet);
			Console.ReadLine();
			//-------------------------------KOD ÇIKTISI !-------------------------------------------
			/*
			 Adı:Koray
             Soyadı:Bapoğlu
             Yaşı:22
             Cinsiyeti:Erkek
			 */
			//-----------------------------------------------------------------------------------------------------------------------------
			/*
			 Herhangi bir hata almadık çünkü c# dilinde eğer oluşturduğumuz classın herhangi bir constructor(yapıcı) methodu bulunmuyorsa
			 kendisi -DEFAULT CONSTRUCTOR- tanımlayarak Nesneyi oluşturuyor.Bunada 'DEFAULT CONSTRUCTOR' diyoruz.
			*/

		}
	}
}