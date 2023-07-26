using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mini_Proje
{
	internal class Father : GrandFather
	{
		//BABADAN YOK DEDEDEN YOK
		public Father() : base()
		{
			Console.WriteLine("Babadanda Miras Yok");
		}
		//BABADAN YOK DEDEDEN ARABA YOK EV VAR
		public Father(int dededenkalanevsayisi, int bos, int bos2, int bos3, int bos4, string s) : base(dededenkalanevsayisi) //5 int 1 string 
		{
			Console.WriteLine("Babadan Miras Yok");
		}
		//BABADAN YOK DEDEDEN ARABA VAR EV YOK
		public Father(int dededenkalanarabasayisi, int bos, int bos2, int bos3, int bos4, int bos5) : base(dededenkalanarabasayisi) //6 int
		{
			Console.WriteLine("Babadan Miras Yok");
		}
		//BABADAN YOK DEDEDEN ARABA VAR EV VAR
		public Father(int dededenkalanarabasayisi, int dededenkalanevsayisi, int bos) : base(dededenkalanevsayisi, dededenkalanarabasayisi) //3 int
		{
			Console.WriteLine("Babadan Miras Yok");
		}
		//-----------------------------------------------------------------------
		//BABADAN ARABA VAR EV YOK DEDEDEN YOK
		public Father(int arabasayisi) : base() //1 int
		{
			Console.WriteLine("Babadan Kalan Araba Sayisi:" + arabasayisi);
		}
		//BABADAN ARABA VAR EV YOK DEDEDEN EV YOK ARABA VAR
		public Father(int arabasayisi, int dededenkalanarabasayisi, int bos, string bos2) : base(dededenkalanarabasayisi, bos2) //3 İNT 1 string
		{
			Console.WriteLine("Babadan Kalan Araba Sayisi:" + arabasayisi);
		}
		//BABADAN ARABA VAR EV YOK DEDEDEN EV VAR ARABA YOK
		public Father(int Evsayisi, int dededenkalanevsayisi, string bos) : base(dededenkalanevsayisi) //2 int 1 string
		{
			Console.WriteLine("Babadan Kalan Ev Sayisi:" + Evsayisi);
		}
		//BABADAN ARABA VAR EV YOK DEDEDEN EV VAR ARABA VAR
		public Father(int arabasayisi, int dededenkalanevsayisi, int dededenkalanarabasayisi, float bos) : base(dededenkalanevsayisi, dededenkalanarabasayisi) //3 int 1 float
		{
			Console.WriteLine("Babadan Kalan Araba Sayisi:" + arabasayisi);
		}

		//BABADAN EV VAR ARABA YOK DEDEDEN YOK
		public Father(int EvSayisi, string s) : base() //1 int 1 string
		{
			Console.WriteLine("Babadan Kalan Ev Sayisi:" + EvSayisi);
		}
		//BABADAN EV VAR ARABA YOK DEDEDEN EV YOK ARABA VAR
		public Father(int EvSayisi, int dededenkalanarabasayisi, float bos) : base(dededenkalanarabasayisi, "Bos") //2 İNT 1 FLOAT
		{
			Console.WriteLine("Babadan Kalan Ev Sayisi:" + EvSayisi);
		}
		//BABADAN EV VAR ARABA YOK DEDEDEN EV VAR ARABA YOK
		public Father(int EvSayisi, int dededenkalanevsayisi, int bos, int bos2) : base(dededenkalanevsayisi) //4 int 
		{
			Console.WriteLine("Babadan Kalan Ev Sayisi:" + EvSayisi);
		}
        //BABADAN EV VAR ARABA YOK DEDEDEN EV VAR ARABA VAR
        public Father(int EvSayisi,int dededenkalanevsayisi,int dededenkalanarabasayisi,char bos):base() //3 int 1 char
        {
			Console.WriteLine("Babadan Kalan Ev Sayisi:" + EvSayisi);
        }
        //BABADAN EV VE ARABA VAR DEDEDEN YOK
        public Father(int EvSayisi, int arabasayisi) : base() //2 İNT
		{
			Console.WriteLine("Babadan Kalan Ev Sayisi:" + EvSayisi);
			Console.WriteLine("Babadan Kalan Araba Sayisi:" + arabasayisi);
		}
		//BABADAN EV VE ARABA VAR DEDEDEN EV YOK ARABA VAR
		public Father(int Evsayisi, int arabasayisi, int dededenkalanarabasayisi, float bos, int bos2) : base(dededenkalanarabasayisi, "bos") //4 int 1 float
		{
			Console.WriteLine("Babadan Kalan Ev Sayisi:" + Evsayisi);
			Console.WriteLine("Babadan Kalan Araba Sayisi:" + arabasayisi);
		}
		//BABADAN EV VE ARABA VAR DEDEDEN EV VAR ARABA YOK
		public Father(int Evsayisi, int arabasayisi, int dededenkalanevsayisi, bool bos) : base(dededenkalanevsayisi)
		{
			Console.WriteLine("Babadan Kalan Ev Sayisi:" + Evsayisi);
			Console.WriteLine("Babadan Kalan Araba Sayisi:" + arabasayisi);
		}
		//BABADAN EV VAR ARABA VAR DEDEDEN EV VAR ARABA VAR
		public Father(int EvSayisi, int arabasayisi, int dededenkalanevsayisi, int dededenkalanarabasayisi, int bos) : base(dededenkalanevsayisi, dededenkalanarabasayisi) //5 int
		{
			Console.WriteLine("Babadan Kalan Ev Sayisi:" + EvSayisi);
			Console.WriteLine("Babadan Kalan Araba Sayisi:" + arabasayisi);
		}

	}
}
