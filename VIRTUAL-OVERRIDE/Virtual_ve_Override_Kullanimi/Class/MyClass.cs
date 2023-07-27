using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Virtual_Override
{
	internal class MyClass
	{

	}
	class A
	{
       public virtual void SinirHastaligi() //BURADA TANIMLAMIŞ OLDUĞUMUZ VİRTUAL(SANAL) METHOD SAYESİNDE KALITIM ALAN KİŞİLER İSTERSE
			                                //BUNU EZİP GEÇEBİLİR VEYA DEĞİŞTİREBİLİR.

											//EĞER HİÇBİR DEĞİŞİKLİK YAPILMAZSA EZME VEYA DEĞİŞTİRME KALMAZSA KALITIM ALAN SINIF OTOMATİK
											//OLARAK KULLANICAKTIR.
		{
            Console.WriteLine("Ben Sinir Hastasıyım");
        }
    }
	class B:A
	{
		public override void SinirHastaligi() 
		{
            Console.WriteLine("Ben Artık Sinir Hastası Değilim"); //BURADA B SINIFI A SINIFINDAN KALITIM ALMAKTADIR.VE A SINIFINDA OLUŞTURULAN
			//SİNİR HASTALIĞI ADLI METHODUDA OTOMATİK OLARAK ALMAKTADIR.FAKAT İSTEĞE BAĞLI OLARAK BUNU EZEBİLİR VE DEĞİŞTİREBİLİR BUNADA OVERRİDE
			//İŞLEMİ DENİLMEKTEDİR.

			//PEKİ B SINIFINDAN KALITIM ALAN C SINIFI OLUŞTURULAN SİNİR HASTALIĞI METHODU A SINIFINDA OLAN METHODU MU YOKSA EZİLMİŞ OLAN B
			//SINIFINDAKİ METHODU MU KULLANACAKTIR ?
        }
	}
	//DENEME 2 İÇİN ÜRETİLMİŞTİR.
	//class C : B 
	//{

	//}
	//DENEME 3 İÇİN ÜRETİLMİŞTİR.
	class C : B //OVERRİDE İŞLEMİ YAPILMIŞ CLASS OLAN B SINIFINDAN KALITIM ALDIK.
    {
		public override void SinirHastaligi()
		{
			Console.WriteLine("Ben Artık Sinir Hastası Değilim ama Deliyim"); //NE KADAR B SINIFINDAN EZİLEN BİR METHOD OLSADA GÜN SONUNDA OVERRİDE
			//İŞLEMİ YAPABİLİYORUZ.
		}
	}
}
