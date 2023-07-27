namespace Virtual_Override
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//A SINIFINDAN KALITIM ALARAK VİRTUAL(SANAL) SINIFI OVERRİDE(EZEREK) DEĞİŞTİREN B SINIFI OLUŞTURULDUĞUNDA EKRANA NE ÇIKTISI OLUŞUR ?
			#region DENEME1
			A a = new A(); //A SINIFINDAN NESNE OLUŞTURUYORUZ.
			a.SinirHastaligi(); //OLUŞTURULAN NESNEDEN OLUŞTURULMUŞ OLDUĞU SINIFTAN SİNİRHASTALIĞI METHODUNU ÇAĞIRAMASINI İSTİYORUZ.
			B b = new B(); // A SINIFINDAN KALITIM ALAN B SINIFINDAN NESNE OLUŞTURUYORUZ.
			b.SinirHastaligi(); // A SINIFINDAN BULUNAN SİNİRHASTALIĞI ADLI METHODU OVERRİDE(EZEREK) DEĞİŞTİRMİŞTİK.
			Console.ReadLine();
			Console.Clear();
			//-------------------------------------------EKRAN ÇIKTISI---------------------------------------------------------------------------
			/* 
			 Ben Sinir Hastasıyım // A SINIFININ VİRTUAL(SANAL) OLARAK İŞARETLENEN SİNİRHASTALIĞI METHODU ÇALIŞTI.
             Ben Artık Sinir Hastası Değilim //A SINIFINDAN KALITIM ALAN B SINIFININ OVERRİDE(EZEREK) SİNİR HASTALIĞI METHODU ÇALIŞTI.
			//***********************************************************************************************************************************
			//EĞER OVERRİDE ETMESEYDİK A SINIFINDA OLUŞTURMUŞ OLDUĞUMUZ METHOD İLE AYNI ŞEKİLDE ÇALIŞICAKTI.
			 */
			#endregion
			//PEKİ OVERRİDE EZİLMİŞ METHODDAN KALITIM ALAN BAŞKA BİR CLASS OTOMATİK OLARAK HANGİ METHODU ÇALIŞTIRIR ?
			#region DENEME2
			C c=new C();
			c.SinirHastaligi();
			Console.ReadLine();
			Console.Clear();

			//-------------------------------------------EKRAN ÇIKTISI---------------------------------------------------------------------------
			/*
			 Ben Artık Sinir Hastası Değilim //B SINIFINDAN KALITIM ALAN C SINIFI OTOMATİK OLARAK EZMEDEN BU SONUCU VERDİ.
			//*************************************************************************************************************
			//NEDENİ İSE KALITIM ALDIĞIMIZ SINIF A DEĞİL B SINIFIDIR VE B SINIFINDA EZİLMİŞ HALDE BULUNMAKTADIR.
			 */
			#endregion
			//PEKİ OVERRİDE EDİLMİŞ CLASS'TAN KALITIM ALAN SINIF KENDİNE GÖRE OVERRİDE EDEMEZ Mİ ?
			#region DENEME3
			c.SinirHastaligi();
			Console.ReadLine();
			//-------------------------------------------EKRAN ÇIKTISI---------------------------------------------------------------------------
			// Ben Artık Sinir Hastası Değilim ama Deliyim

			//EVET EDİLEBİLİYOR.ÖRNEKTEDE GÖRÜLDÜĞÜ GİBİ C SINIFINDAN OVERRİDE EDEREK METHODU EZEREK KENDİNE GÖRE DOLDURABİLİYORUZ.
			//PEKİ NASIL ? ÇÜNKÜ A SINIFI ATA SINIFI OLDUĞU İÇİN NE KADAR B SINIFINDAN KALITIM ALSAKTA OTOMATİK OLARAK B SINIFI ÇALIŞTIRSADA
			//GÜN SONUNDA A SINIFINDAN VİRTUAL ANAHTAR KELİMESİ İLE İŞARETLENMİŞTİR.
			#endregion

		}
	}
}