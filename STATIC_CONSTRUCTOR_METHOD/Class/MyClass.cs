using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
	internal class MyClass
	{
		public string UyeAdi { get; set; }
		public string UyeSoyadi { get; set; }
		public int UyeYasi { get; set; }
		public MyClass()
		{
			//BU SINIFTAN NESNE ÜRETİLİRKEN İLK TETİKLENECEK OLAN METHODDUR.
			Console.WriteLine("Üye Oluşturuluyor.");
		}
		static MyClass()
		{
			//BU SINIFTAN İLK NESNE ÜRETİLİRKEN İLK TETİKLENECEK OLAN METHODDUR.
			Console.WriteLine("İlk Üye Oluşturuluyor.");
			// STATİC CONSTRUCTOR TETİKLENEBİLMESİ İÇİN İLLA Kİ STATİC CONSTRUCTOR OLUŞTURMAMIZA GEREK YOKTUR.
			// İLGİLİ SINIF İÇİNDE HERHANGİ BİR STATİC YAPILANMANINDA TETİKLENMESİ STATİC COSNT. TETİKLENMESİNİ SAĞLAYACAKTIR.
		}
	}
}
