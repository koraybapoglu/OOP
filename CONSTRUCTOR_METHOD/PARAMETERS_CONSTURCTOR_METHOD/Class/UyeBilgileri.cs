using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersConstructor
{
	internal class UyeBilgileri
	{
		public UyeBilgileri(string UyeAdi, string UyeSoyadi, int UyeYasi, string UyeCinsiyet) //Parametreli Constructor Oluşturduk !
		{
			Console.WriteLine("Nesne Oluşturuluyor !");
			this.UyeAdi = UyeAdi; //THİS KEYWORDU KULLANILARAK BU CLASS'TAKİ UyeAdi Propertysi çağırıldı !
			this.UyeSoyadi = UyeSoyadi; //THİS KEYWORDU KULLANILARAK BU CLASS'TAKİ UyeSoyadi Propertysi çağırıldı !
			this.UyeCinsiyet = UyeCinsiyet; //THİS KEYWORDU KULLANILARAK BU CLASS'TAKİ UyeCinsiyet Propertysi çağırıldı !
			this.UyeYasi = UyeYasi; //THİS KEYWORDU KULLANILARAK BU CLASS'TAKİ UyeYasi Propertysi çağırıldı !
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
