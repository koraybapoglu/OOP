using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedKeyword
{
	internal class Hayvan
	{
		public virtual void Tanit()
		{
			Console.WriteLine("Ben bir Hayvanim");
		}

	}
	class Kus : Hayvan
	{
		sealed public override void Tanit() //BURADA TANIMLAMIŞ OLDUĞUMUZ SEALED KEYWORD'Ü SAYESİNDE ARTIK VİRTUAL İLE İŞARETLENMİŞ OLAN TANİT METHODUNU ARTIK OVERRİDE(EZME) GİRİŞİNİ ALT CLASS'LARDA ENGELLEMİŞ OLDUK.
		{
			Console.WriteLine("Ben bir Kuşum");
		}
	}
	class Muhabbet_Kusu : Kus
	{
		public sealed override void Tanit()
		{
			Console.WriteLine("Ben Bir Muhabbet Kuşuyum"); //HATA VERİYOR.
		}
	}
}
