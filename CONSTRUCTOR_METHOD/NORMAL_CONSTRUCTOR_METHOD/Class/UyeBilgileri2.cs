using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
	class UyeBilgileri2
	{
		public UyeBilgileri2() //Constructor methodumuzu oluşturduk !
		{
			
			UyeAdi = "Koray";
			UyeSoyadi = "Bapoğlu";
			UyeYasi = 22;
			UyeCinsiyet = "Erkek";   //Nesneye ait özelliklere ilk değerlerini girdik !
			Console.WriteLine("Nesne Oluşturuluyor !"); //Yapıcı Method bittikten sonra kullanıcıya bilgi verdik !
		}
		private string _UyeAdi;
		public string UyeAdi
		{
			get
			{
				return _UyeAdi;
			}
			set
			{
				_UyeAdi = value;
			}
		}
		private string _UyeSoyadi;
		public string UyeSoyadi
		{
			get
			{
				return _UyeSoyadi;
			}
			set
			{
				_UyeSoyadi = value;
			}
		}
		private int _UyeYasi;
		public int UyeYasi
		{
			get
			{
				return _UyeYasi;
			}
			set
			{
				_UyeYasi = value;
			}
		}
		string _UyeCinsiyet;
		public string UyeCinsiyet { get; set; }
	}
}
