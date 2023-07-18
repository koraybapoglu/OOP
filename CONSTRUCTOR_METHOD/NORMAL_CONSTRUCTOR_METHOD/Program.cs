namespace Constructor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//-----------------------------------------------------Örnek 1--------------------------------------------------------------------------
			ÜyeBilgileri Ahmet = new ÜyeBilgileri(); //C# Dilinde '()' bir methodu temsil etmektedir ve newleyerek oluşturduğumuz nesnedede sonunda parantez kullanmak zorundayız.Bu parantezde o nesnenin yapıcı methodunu çağırmaktadır.
			Ahmet.UyeAdi = "Ahmet";
			Ahmet.UyeSoyadi = "Taş";
			Ahmet.UyeYasi = 33;
			Ahmet.UyeCinsiyet = "Erkek";
			Console.WriteLine("Adı:" + Ahmet.UyeAdi);
			Console.WriteLine("Soyadı:" + Ahmet.UyeSoyadi);
			Console.WriteLine("Cinsiyet:" + Ahmet.UyeCinsiyet);
			Console.WriteLine("Yaşı:" + Ahmet.UyeYasi);
			Console.WriteLine("Nesne Başarıyla oluşturuldu !");
			Console.ReadLine();
			Console.Clear();
			//-------------------------------KOD ÇIKTISI !-------------------------------------------
			/* 
			 Nesne Oluşturuluyor !
             Adı:Ahmet
             Soyadı:Taş
             Cinsiyet:Erkek
             Yaşı:33
             Nesne Başarıyla oluşturuldu !
			*/
			//Constructor(Yapıcı METHOD kullanarak nesne oluştururken kullanıcıya nesne oluşturuluyor çıktısı vermiş olduk !
			//Peki başka ne için kullanabiliriz ?
			//Propertylere ilk değerlerini girebiliriz.
			//Peki Constructor method oluşturmadan nesne oluşturabilir miyiz ? (Evet,Bunada Default Constructor diyoruz.Visual Studio oluşturmadığımız constructorları kendisi default olarak ayarlayarak nesneyi oluşturur.)
			//Peki Constructor method oluşturduktan sonra Default Constructor ne oluyor ?(Cevabı gayet kısa bir şekilde ezmiş oluyoruz.)

			UyeBilgileri2 deneme = new UyeBilgileri2();   //Nesne Oluşturuldu Constructor Method Çalıştı ! (Nesneye ait olan default değerler consturctor'da eklendi !)
			UyeBilgileri2 deneme2 = new UyeBilgileri2();  //Nesne Oluşturuldu Constructor Method Çalıştı ! (Nesneye ait olan default değerler consturctor'da eklendi !)
			deneme2.UyeAdi = "Ahmet";
			UyeBilgileri2 deneme3 = new UyeBilgileri2();  //Nesne Oluşturuldu Constructor Method Çalıştı ! (Nesneye ait olan default değerler consturctor'da eklendi !)
			deneme3.UyeYasi = 33;
			UyeBilgileri2 deneme4 = new UyeBilgileri2();  //Nesne Oluşturuldu Constructor Method Çalıştı ! (Nesneye ait olan default değerler consturctor'da eklendi !)
			deneme4.UyeSoyadi = "Baps";
			UyeBilgileri2[] uyeler = new UyeBilgileri2[] { deneme, deneme2, deneme3, deneme4 };
			foreach (var item in uyeler)
			{
				Console.WriteLine(item.UyeAdi);
				Console.WriteLine(item.UyeSoyadi);
				Console.WriteLine(item.UyeYasi);
				Console.WriteLine(item.UyeCinsiyet);
				Console.WriteLine("Nesne Başarıyla Oluşturuldu !");
			}
			Console.ReadLine();
			//-------------------------------KOD ÇIKTISI !-------------------------------------------
			/*
			   Nesne Oluşturuluyor !
               Nesne Oluşturuluyor !
               Nesne Oluşturuluyor !
               Nesne Oluşturuluyor !
               Koray
               Bapoğlu
               22
               Erkek
               Nesne Başarıyla Oluşturuldu !
               Ahmet
               Bapoğlu
               22
               Erkek
               Nesne Başarıyla Oluşturuldu !
               Koray
               Bapoğlu
               33
               Erkek
               Nesne Başarıyla Oluşturuldu !
               Koray
               Baps
               22
               Erkek
               Nesne Başarıyla Oluşturuldu !
			 */

		}
	}
}