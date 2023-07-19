using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersConstructor
{
	internal class UyeBilgileri
	{
		public UyeBilgileri(string UyeAdi, string UyeSoyadi, int UyeYasi, string UyeCinsiyet) // Tüm Parametreli Alan Constructor Oluşturduk !
		{
			this.UyeAdi = UyeAdi; //THİS KEYWORDU KULLANILARAK BU CLASS'TAKİ UyeAdi Propertysi çağırıldı !
			this.UyeSoyadi = UyeSoyadi; //THİS KEYWORDU KULLANILARAK BU CLASS'TAKİ UyeSoyadi Propertysi çağırıldı !
			this.UyeCinsiyet = UyeCinsiyet; //THİS KEYWORDU KULLANILARAK BU CLASS'TAKİ UyeCinsiyet Propertysi çağırıldı !
			this.UyeYasi = UyeYasi; //THİS KEYWORDU KULLANILARAK BU CLASS'TAKİ UyeYasi Propertysi çağırıldı !
		}
		public UyeBilgileri() // Hiçbir Parametre almayan Boş Constructor Oluşturduk!
		{
			this.UyeAdi = "Girilmedi !";
			this.UyeSoyadi = "Girilmedi !";
			this.UyeYasi = 0; ;
			this.UyeCinsiyet = "Girilmedi !";
		}
		public UyeBilgileri(string UyeAdi) //Üye Adı parametresini alan Constructor Oluşturduk !
		{
			this.UyeAdi = UyeAdi;
			this.UyeSoyadi = "Girilmedi !";
			this.UyeYasi = 0; ;
			this.UyeCinsiyet = "Girilmedi !";
		}
		public UyeBilgileri(string UyeAdi, string UyeSoyadi) //Üyenin Ad ve Soyad parametresini alan Constructor Oluşturduk !
		{
			this.UyeAdi = UyeAdi;
			this.UyeSoyadi = UyeSoyadi;
			this.UyeYasi = 0; ;
			this.UyeCinsiyet = "Girilmedi !";
		}
		public UyeBilgileri(string UyeAdi, string UyeSoyadi, int UyeYasi) //Üyenin ad,soyad ve yaş parametresini alan Constructor Oluşturduk !
		{
			this.UyeAdi = UyeAdi;
			this.UyeSoyadi = UyeSoyadi;
			this.UyeYasi = UyeYasi; ;
			this.UyeCinsiyet = "Girilmedi !";
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
		public string UyeCinsiyet { get; set; } //Otomatik Field oluşturan property tanımladık.
	}
}
