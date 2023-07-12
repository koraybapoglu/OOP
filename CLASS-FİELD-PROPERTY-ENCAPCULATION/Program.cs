using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeclass
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ÜYELER FULL PROPERTY CLASSINDAN NESNELER OLUŞTURDUK !
			üyelerfullprop Ahmet = new üyelerfullprop();
			//NESNELERE VERİLER GİRDİK.
			Ahmet.ÜyeAdi = "Ahmet";
			Ahmet.ÜyeSoyadi = "Taştan";
			üyelerfullprop Mahmut = new üyelerfullprop();
			Mahmut.ÜyeAdi = "Mahmut";
			Mahmut.ÜyeSoyadi = "Ünver";
			üyelerfullprop Koray = new üyelerfullprop();
			Koray.ÜyeAdi = "Koray";
			Koray.ÜyeSoyadi = "Bapoğlu";
			//NESNELERİ DİZİN İÇERİSİNE AKTARDIK.
			üyelerfullprop[] _üyelerfullprop = new üyelerfullprop[3];
			_üyelerfullprop[0] = Ahmet;
			_üyelerfullprop[1] = Mahmut;
			_üyelerfullprop[2] = Koray;
			//NESNELERİ DÖNGÜ İLE YAZDIRDIK.
			foreach (var item in _üyelerfullprop)
			{
				Console.WriteLine(item.ÜyeAdi + " " + item.ÜyeSoyadi);
			}
			Console.WriteLine("********************************************************************************");
			Console.WriteLine();
			//ÜYELER PROPERTY CLASSINDAN NESNELER OLUŞTURDUK !
			üyelerprop Ahmet2 = new üyelerprop();
			//NESNELERE VERİLER GİRDİK.
			Ahmet2.ÜyeAdi = "Ahmet";
			Ahmet2.ÜyeSoyadi = "Taştan";
			üyelerprop Mahmut2 = new üyelerprop();
			Mahmut2.ÜyeAdi = "Mahmut";
			Mahmut2.ÜyeSoyadi = "Ünver";
			üyelerprop Koray2 = new üyelerprop();
			Koray2.ÜyeAdi = "Koray";
			Koray2.ÜyeSoyadi = "Bapoğlu";
			//NESNELERİ DİZİN İÇERİSİNE AKTARDIK.
			üyelerprop[] _üyelerprop = new üyelerprop[3];
			_üyelerprop[0] = Ahmet2;
			_üyelerprop[1] = Mahmut2;
			_üyelerprop[2] = Koray2;
			//NESNELERİ DÖNGÜ İLE YAZDIRDIK.
			foreach (var item in _üyelerprop)
			{
				Console.WriteLine(item.ÜyeAdi + " " + item.ÜyeSoyadi);
			}
			Console.ReadLine();
			//----------EKRAN ÇIKTISI-----------------------------------------------
			/* Ahmet Taştan
               Mahmut Ünver
               Koray Bapoğlu
               ********************************************************************************

               Ahmet Taştan
               Mahmut Ünver
               Koray Bapoğlu
			-------------------------------------------------------------------------
           */
		}
	}
}
