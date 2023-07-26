namespace KalitimOrnek
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//NESNE OLUŞTURDUĞUMUZDA OLUŞTURMAK İSTEDİĞİMİZ NESNENİN CLASS'I EĞER KALITIM ALIYORSA İLK OLARAK KALITIM ALDIĞI CLASS'DAN
			//NESNE OLUŞTURUR.

			//EĞER O CLASS'DA BAŞKA BİR CLASS'DAN KALITIM ALIYORSA SİSTEM OTOMATİK OLARAK ONDANDA NESNE ÜRETİR.EN ÜST CLASS HANGİSİ
			//İSE ONDAN NESNE OLUŞTURUR OTOMATİK OLARAK.

			// DENEME:
			Console.WriteLine("Son Nesne Oluşturma Başlatıldı !!!");
			Console.WriteLine("******************************************");
			Console.WriteLine("Çıktı:");
			Console.WriteLine();
			new Son(); //BURADA NE KADAR SON CLASS'INDAN NESNE OLUŞTURSAKTA SON CLASSI FATHER CLASS'DAN KALITIM ALMAKTADIR.
			//FATHER CLASS'I İSE GRANDFATHER CLASS'INDAN KALITIM ALMAKTADIR.
			//BURADA OLUŞTURACAĞIMIZ NESNEDE İLK OLARAK SİSTEM OTOMATİK OLARAK GRANDFATHER CLASS'INDAN NESNE OLUŞTURUR ARDINDAN FATHER NESNESİNDEN
			//ARDINDAN İSE SON CLASS'INDAN NESNE OLUŞTURUR.
			Console.WriteLine("******************************************");
			Console.WriteLine("Father Nesne Oluşturma Başlatıldı !!!");
			Console.WriteLine("******************************************");
			Console.WriteLine("Çıktı:");
			Console.WriteLine();
			new Father();
			//BURADA FATHER CLASS'INDAN YENİ BİR NESNE ÜRETMEK İSTİYORUZ.FAKAT FATHER CLASS'I GRANDFATHER CLASS'INDAN KALITIM ALMAKTADIR.
			//BU NEDEN İLK OLARAK SİSTEM OTOMATİK OLARAK GRANDFATHER CLASS'DAN NESNE ÜRETİR ARDINDAN İSE FATHER CLASS'INDAN NESNE ÜRETİR.
			Console.WriteLine("******************************************");
			Console.WriteLine("GrandFather Nesne Oluşturma Başlatıldı !!!");
			Console.WriteLine("******************************************");
			Console.WriteLine("Çıktı:");
			Console.WriteLine();
			new GrandFather(); //BURA ATA CLASS'IMIZ OLDUĞU İÇİN DİREK OLARAK GRANDFATHER CLASS'INDAN YENİ BİR NESNE ÜRETİLİR.
			Console.ReadLine();
			/*
			 //--------------------------------------------------------------EKRAN ÇIKTISI--------------------------------------------------
		    Son Nesne Oluşturma Başlatıldı !!!
            ******************************************
            Çıktı:

            GrandFather Nesnesi Oluşturulmuştur.
            Father Nesnesi Oluşturulmuştur.
            Son Nesnesi Oluşturulmuştur.
            ******************************************
            Father Nesne Oluşturma Başlatıldı !!!
            ******************************************
            Çıktı:

            GrandFather Nesnesi Oluşturulmuştur.
            Father Nesnesi Oluşturulmuştur.
            ******************************************
            GrandFather Nesne Oluşturma Başlatıldı !!!
            ******************************************
            Çıktı:

            GrandFather Nesnesi Oluşturulmuştur.
	         
	         */
		}
	}
}