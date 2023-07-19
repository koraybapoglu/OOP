using System.Net.Http.Headers;

namespace ParametersConstructor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UyeBilgileri bos = new UyeBilgileri();
			UyeBilgileri bosadi = new UyeBilgileri("Koray");
			UyeBilgileri bosadisoyadi = new UyeBilgileri("Koray", "Bapoğlu");
			UyeBilgileri bosadisoyadiyasi = new UyeBilgileri("Koray", "Bapoğlu", 22);
			UyeBilgileri dolu = new UyeBilgileri("Koray", "Bapoğlu", 22, "Erkek");
			UyeBilgileri[] uyes = new UyeBilgileri[] { bos, bosadi, bosadisoyadi, bosadisoyadiyasi, dolu };
			foreach (var item in uyes)
			{
				Console.WriteLine("ADI:" + item.UyeAdi);
				Console.WriteLine("SOYADI:" + item.UyeSoyadi);
				Console.WriteLine("YAŞI:" + item.UyeYasi);
				Console.WriteLine("CİNSİYETİ:" + item.UyeCinsiyet);
				Console.WriteLine("---------------------------------------------");
				Console.WriteLine();
			}
			Console.ReadLine();
			//-------------------------------KOD ÇIKTISI !-------------------------------------------
			/*
             ADI:Girilmedi !
             SOYADI:Girilmedi !
             YAŞI:0
             CİNSİYETİ:Girilmedi !
             ---------------------------------------------   ("HİÇBİR PARAMETRE ALMAYAN CONSTRUCTOR(YAPICI METHOD ÇALIŞTI)")

             ADI:Koray
             SOYADI:Girilmedi !
             YAŞI:0
             CİNSİYETİ:Girilmedi !
             ---------------------------------------------  ("AD PARAMETRESİ ALAN CONSTRUCTOR(YAPICI METHOD ÇALIŞTI)")

             ADI:Koray
             SOYADI:Bapoğlu
             YAŞI:0
             CİNSİYETİ:Girilmedi !
             --------------------------------------------- ("AD VE SOYAD PARAMETRESİ ALAN CONSTRUCTOR(YAPICI METHOD ÇALIŞTI)")

             ADI:Koray
             SOYADI:Bapoğlu
             YAŞI:22
             CİNSİYETİ:Girilmedi !
             --------------------------------------------- ("AD,SOYAD,YAŞ PARAMETRESİ ALAN CONSTRUCTOR(YAPICI METHOD ÇALIŞTI)")

             ADI:Koray
             SOYADI:Bapoğlu
             YAŞI:22
             CİNSİYETİ:Erkek
             --------------------------------------------- (BÜTÜN PARAMETLERİ ALAN CONSTRUCTOR(YAPICI METHOD ÇALIŞTI)")
			 */
		}
	}
}