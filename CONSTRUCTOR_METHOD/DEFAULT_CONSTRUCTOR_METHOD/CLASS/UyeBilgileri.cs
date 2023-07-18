using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructor
{
	internal class UyeBilgileri
	{
		//Constructor Tanımlamadım !
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
		public string UyeSoyadi { get; set; } //Field Tanımlamadım otomatik sistem tanımladı !
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
		public string UyeCinsiyet { get; set; } //Field Tanımlamadım otomatik sistem tanımladı !

	}
}

