using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mini_Proje
{
	internal class GrandFather
	{
		public GrandFather()
		{
            Console.WriteLine("Dededen Miras Yok.");
        }
        public GrandFather(int EvSayisi)
        {
            Console.WriteLine("Dededen Kalan Ev Sayısı:" + EvSayisi);
        }
        public GrandFather(int ArabaSayisi,string a)
        {
            Console.WriteLine("Dededen Kalan Araba Sayisi:"+ArabaSayisi);
        }
        public GrandFather(int EvSayisi,int arabasayisi)
        {
            Console.WriteLine("Dededen Kalan Ev Sayisi:"+EvSayisi);
            Console.WriteLine("Dededen Kalan Araba Sayisi:"+arabasayisi);
        }
    }

}
