using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
	internal class ÜyeBilgileri
	{
		public ÜyeBilgileri()
		{
			//OLUŞTURDUĞUMUZ CONSTRUCTOR METOTTUR !
			//NESNE OLUŞTURULURKEN ONU YAPICI METODUDUR !
			Console.WriteLine("Nesne Oluşturuluyor !");
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
		public string UyeSoyadi {
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
		public int UyeYasi {
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
