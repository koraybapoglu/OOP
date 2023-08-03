namespace İnterface
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//INTERFACE NEDİR ?

			//INTERFACE BİR SÖZLEŞMEDİR VE SINIFLARIN İMZASIDIR.

			//INTERFACE NE İŞE YARAR NEDEN KULLANIRIZ ?

			//GELİŞTİRİCİ İLE ETKİLEŞİMİ DAHA KOLAYDIR.
			//YAPILAR ARASINDA ETKİLEŞİM DAHA KOLAYDIR.
			//İNTERFACE ABSTRACT CLASS'IN SADECE İMZALARA KONSTANSTRE OLMUŞ HALİDİR. O YÜZDEN ABSTRACTİON DAVRANIŞI AÇISINDAN ABSTRACT CLASS'A NAZARAN DAHA ELVERİŞLİ VE KULLANIŞLIDIR.
			IUyeEkle eklenecekolanuye = new Uye(); //BURADA POLİMORFİZM'DEN YARARLANARAK IUYEEKLE INTERFACE'İNİ REFERANS GÖSTEREREK YENİ BİR UYE NESNESİ OLUŞTURDUK.

			eklenecekolanuye.uyeEkle(); //BURADA BİZİM KARŞIMIZA REFERANS GÖSTERDİĞİMİZ IUyeEkle'de bulunan method haricinde hiçbir method karşımıza çıkmadı ve geliştiricinin işini böylelikle kolaylaştırmış olduk.

			IUyeGuncelle guncellenecekolanuye = new Uye();
			guncellenecekolanuye.uyeGuncelle();

			IUyeSil silinecekolanuye = new Uye();
			silinecekolanuye.uyeSil();

			IUyeGetir getirilicekolanuye = new Uye();
			getirilicekolanuye.uyeGetir(); //BURADADA YAPTIĞIMIZ YUKARIDA YAPTIĞIMIZLA AYNIDIR.

			Console.ReadLine();
			/* -------------------------------------------------------EKRAN ÇIKTISI-----------------------------------------------------------
			 Uye Eklendi !
             Uye Guncellendi !
             Uye Silindi !
             Uye Getirildi !
			 */
		}
	}
	class Uye : IUyeEkle, IUyeSil, IUyeGuncelle, IUyeGetir
	{
		public void uyeEkle()
		{
			Console.WriteLine("Uye Eklendi !");
		}

		public void uyeGetir()
		{
			Console.WriteLine("Uye Getirildi !");
		}

		public void uyeGuncelle()
		{
			Console.WriteLine("Uye Guncellendi !");
		}

		public void uyeSil()
		{
			Console.WriteLine("Uye Silindi !");
		}
	}
	interface IUyeEkle
	{
		void uyeEkle();
	}
	interface IUyeSil
	{
		void uyeSil();
	}
	interface IUyeGuncelle
	{
		void uyeGuncelle();
	}
	interface IUyeGetir
	{
		void uyeGetir();
	}
}