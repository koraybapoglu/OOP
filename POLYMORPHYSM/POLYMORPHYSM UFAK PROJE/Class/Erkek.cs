using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	internal class Erkek : Insan
	{
		public Erkek(string adi, string soyadi, int yasi)
		{
			Adi = adi;
			Soyadi = soyadi;
			Yasi = yasi;
			Tanit();
		}
		public override void Tanit()
		{
			Console.WriteLine("Ben Bir Erkeğim");
		}
		public override string Cinsiyet { get; set; } = "Erkek";
	}
}
