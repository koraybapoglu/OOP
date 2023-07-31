namespace Polimorphysm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//POLİMORPYHSM İÇİN KALITIM ŞARTTIR.
			//BİR NESNENİN BAŞKA BİR NESNE İLE İŞARETLENEBİLMESİ İÇİN KESİNLİKLE ARADA KALITIMSAL BİR İLİŞKİ OLMASI GEREKMEKTEDİR.
			//NESNE TABANLI PROGRAMLAMADA POLİMORPHYSM UYGULANABİLMESİ İÇİN KALITIMSAL İLİŞKİ OLMALIDIR.AKSİ MÜMKÜN DEĞİLDİR.
			C c = new C(); //
			c.X();         //  DOĞRU KULLANIM
			c.Y();         //
			c.Z();         //


			B B = new C(); // 
			B.X();  //    DOĞRU KULLANIM
			B.Y(); //           

			B.Z(); // =>YANLIŞ KULLANIM.
			//NEDENİ İSE B NESNESİ B SINIFINDAN REFERANS GÖSTERİLEREK ÇALIŞMAKTADIR.
			A A = new C();
			A.X(); // =>DOĞRU KULLANIM

			A.Y(); //
			A.Z(); // YANLIŞ KULLANIM NEDENİ İSE A NESNESİ A SINIFINDAN REFERANS GÖSTERİLEREK ÇALIŞMAKTADIR.
		}
	}
}