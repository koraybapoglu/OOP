using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	internal class Kadin:Insan
	{
        public Kadin(string adi,string soyadi,int yasi)
        {
            Adi = adi;
            Soyadi = soyadi;
            Yasi = yasi;
            Tanit();
        }
        public override void Tanit() 
        {
            Console.WriteLine("Ben bir Kadınım.");
        }
        public override string Cinsiyet { get; set; } = "Kadın";
	}
}
