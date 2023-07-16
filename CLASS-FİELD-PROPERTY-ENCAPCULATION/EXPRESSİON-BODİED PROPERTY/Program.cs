using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InıtOnlyProperty
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UyeBilgileri uyebilgiler = new UyeBilgileri
			{
				sayi = 5;
			};

			Console.WriteLine(uyebilgiler.ÜyeAdi);
			Console.WriteLine(uyebilgiler.ÜyeSoyadi);
			/* HATALI KULLANIM */
			uyebilgiler.ÜyeAdi = "Mehmet";
			uyebilgiler.ÜyeSoyadi = "Taş";
			//**********************************//
			// SADECE READONLY PROPERTYLERDE KULLANILIR ! //
			
		}
	}
}
