namespace Virtual_Override_Mini_Proje
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Alanını Hesaplamak istediğiniz Şekli Seçiniz.\nKARE İÇİN 1\nDİKDÖRTGEN İÇİN 2\nÜÇGEN İÇİN 3 TUŞLAYINIZ.");
			int secim = Convert.ToInt32(Console.ReadLine());
			int boy = 0;
			int en = 0;
			if (secim==1) 
			{
                Console.WriteLine("Karenin Kenar Uzunluğunu giriniz:");
				boy = Convert.ToInt32(Console.ReadLine());
				en = boy;
				Kare kare = new Kare(boy,en);
				Console.WriteLine("KARENİN ALANI:"+kare.AlanHesapla());
				Console.ReadLine();
            }
			else if (secim==2)
			{
				Console.WriteLine("Dikdörtgenin Kısa Kenarını Giriniz:");
				boy=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin Uzun Kenarını Giriniz:");
				en = Convert.ToInt32(Console.ReadLine());
				Dikdörtgen dikdörtgen = new Dikdörtgen(boy,en);
                Console.WriteLine("Dikdörtgenin ALANI:"+dikdörtgen.AlanHesapla());
				Console.ReadLine();
            }
			else if (secim==3)
			{
				Console.WriteLine("Üçgenin Taban Uzunluğunu Giriniz:");
				boy= Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Üçgenin Yüksekliğini Giriniz:");
				en= Convert.ToInt32(Console.ReadLine());
				Ucgen ucgen=new Ucgen(boy,en);
                Console.WriteLine("Üçgenin ALANI:"+ucgen.AlanHesapla());
				Console.ReadLine();
            }
			else
			{
                Console.WriteLine("HATALI GİRİŞ YAPTINIZ LÜTFEN TEKRAR DENEYİNİZ.");
                Console.WriteLine("PROJE KAPATILIYOR...");
                Thread.Sleep(3000);
				Environment.Exit(0);
            }
		}
		//-------------------------------------EKRAN ÇIKTISI-----------------------------------------------------------------------------
		/*
		 -----------KARE-------------------------------
		 Alanını Hesaplamak istediğiniz Şekli Seçiniz.
         KARE İÇİN 1
         DİKDÖRTGEN İÇİN 2
         ÜÇGEN İÇİN 3 TUŞLAYINIZ.
         1
         Karenin Kenar Uzunluğunu giriniz:
         15
         KARENİN ALANI:225
		----------------------------------------------
		-----------DİKDÖRTGEN-------------------------
		Alanını Hesaplamak istediğiniz Şekli Seçiniz.
        KARE İÇİN 1
        DİKDÖRTGEN İÇİN 2
        ÜÇGEN İÇİN 3 TUŞLAYINIZ.
        2
        Dikdörtgenin Kısa Kenarını Giriniz:
        20
        Dikdörtgenin Uzun Kenarını Giriniz:
        25
        Dikdörtgenin ALANI:500
		---------------------------------------------
		---------------ÜÇGEN-------------------------
		Alanını Hesaplamak istediğiniz Şekli Seçiniz.
        KARE İÇİN 1
        DİKDÖRTGEN İÇİN 2
        ÜÇGEN İÇİN 3 TUŞLAYINIZ.
        3
        Üçgenin Taban Uzunluğunu Giriniz:
        25
        Üçgenin Yüksekliğini Giriniz:
        30
        Üçgenin ALANI:375
		---------------------------------------------
		 */
	}
}