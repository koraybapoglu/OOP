namespace ParametersConstructor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UyeBilgileri Koray = new UyeBilgileri("Koray","Bapoğlu",22,"Erkek"); //PARAMETRELİ CONSTRUCTOR'A PARAMETLERİ VERİLEREK NESNE
																				 // OLUŞTURMASI YAPILDI.
			Console.WriteLine(Koray.UyeAdi);
			Console.WriteLine(Koray.UyeSoyadi);
			Console.WriteLine(Koray.UyeYasi);
			Console.WriteLine(Koray.UyeCinsiyet);
			Console.ReadLine();
			//-------------------------------KOD ÇIKTISI !-------------------------------------------
			/*
			 Nesne Oluşturuluyor !
             Koray
             Bapoğlu
             22
             Erkek
			 */
		}
	}
}