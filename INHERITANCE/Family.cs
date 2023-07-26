using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnek
{
	internal class Family
	{
		class GrandFather //FATHER CLASSI İÇİN BASE CLASSTIR.
		{
            public string ElaGöz { get; set; }
            public string Kellik { get; set; }
            public string ŞekerHastalığı { get; set; }
        }
		class Father:GrandFather //BU CLASS'TA DELİVER CLASS(KALITIM ALAN CLASS) FATHER CLASSIDIR.BASE CLASS(KALITIM VEREN CLASS) İSE GRANDFATHER CLASSIDIR.
		{
			//*******************************************************************************************************************************

            public int Sakal { get; set; }
            public int Tansiyon { get; set; }
			//FATHER CLASSI BASE CLASSI OLAN GRANDATHER CLASSINDAN İSE ELAGÖZ ÖZELLİĞİNİ KELLİK ÖZELLİĞİNİ VE
			//ŞEKER HASTALIĞI ÖZELLİĞİNİ KALITSAL OLARAK ALMIŞTIR.

			//********************************************************************************************************************************
        }
		class Son :Father //BU CLASS'TA DELİVER CLASS(KALITIM ALAN CLASS) SON CLASSIDIR.BASE CLASS(KALITIM VEREN CLASS) İSE FATHER CLASSIDIR.
		{ //EKSTRA OLARAK GRANDFATHER CLASSI SON CLASSI İÇİN BASE CLASS DEĞİLDİR.ATA CLASS OLARAK DEĞERLENDİREBİLİRİZ.
            public string UzunBoy { get; set; }  
			//YAPTIĞIMIZ KALITIM SONUCU SON CLASSI GRANDFATHER CLASSINDAN ELAGÖZ ÖZELLİĞİNİ KELLİK ÖZELLİĞİNİ VE
			//ŞEKER HASTALIĞI ÖZELLİĞİNİ KALITSAL OLARAK ALMIŞTIR.

			//BASE CLASSI OLAN(FATHER CLASSI GRANDFATHER CLASSI DEĞİL !!!!!!!!!!!!!!!!!) FATHER CLASSINDAN İSE SAKAL ÖZELLİĞİNİ
			//VE TANSİYON ÖZELLİĞİNİ KALITSAL OLARAK ALMIŞTIR.

			//**********************************************************************************************************************************
        }
	}
}
