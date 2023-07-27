using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override_Mini_Proje
{
	internal class Sekil
	{
		protected int _Boy;
		protected int _En;
        public Sekil(int Boy,int En)
        {
			_Boy = Boy;
			_En = En;
        }
		public virtual int AlanHesapla() 
		{
			return 0;
		}
    }
    class Dikdörtgen:Sekil
    {
        public Dikdörtgen(int Boy,int En):base(Boy,En)
        {
            
        }
		public override int AlanHesapla()
		{
             return _Boy* _En;
		}
	}
    class Kare : Sekil 
    {
        public Kare(int Boy,int En):base(Boy,En)
        {
               
        }
		public override int AlanHesapla()
		{
            return _Boy * _Boy;
		}
	}
    class Ucgen : Sekil 
    {
        public Ucgen(int Boy,int En):base(Boy,En)
        {
               
        }
		public override int AlanHesapla()
		{
            return _Boy * _En / 2;
		}
	}
    
}
