using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoproperty
{
	internal class Program
	{
		static void Main(string[] args)
		{
			üyebilgileri yeniuye = new üyebilgileri();
			Console.WriteLine(yeniuye.ÜyeAdi);
			Console.WriteLine(yeniuye.ÜyeSoyadi);
			yeniuye.ÜyeAdi = "Deneme Ad";
			yeniuye.ÜyeSoyadi = "Deneme Soyad";
			Console.WriteLine("Deneme Üye Eklendi !");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(yeniuye.ÜyeAdi);
			Console.WriteLine(yeniuye.ÜyeSoyadi);
			Console.ReadLine();

			/* EKRAN ÇIKTISI */
			/*   Koray
				 Bapoğlu
				 Deneme Üye Eklendi !


				 Deneme Ad
				 Deneme Soyad */

		}
	}
}
