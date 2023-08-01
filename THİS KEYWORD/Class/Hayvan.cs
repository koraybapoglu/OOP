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
			Console.WriteLine("Ben bir Hayvanim"); //PEKİ KALITIM OLMAYAN CLASS'TA BASE KEYWORD'Ü KULLANILAMAZ MI ?

			//CEVABI HAYIR.ÇÜNKÜ BÜTÜN CLASSLAR OBJECT TÜRÜNDEN KALITIM ALDIĞI İÇİN BASE DEDİĞİMİZDE OBJECT CLASSINDA OLAN BÜTÜN METHODLARA ULAŞMIŞ OLACAĞIZ.
		}

	}
	class Kus : Hayvan
	{
		public override void Tanit()
		{
			base.Tanit(); //BURADA BİR KALITIM OLDUĞU İÇİN BASE CLASS OLAN(HAYVAN) CLASSINDAKİ TANİT METHODUNU ÇALIŞTIRIYORUZ.
		}
	}
	class Muhabbet_Kusu : Kus
	{
		public override void Tanit()
		{
			base.Tanit(); //BURADA BİR KALITIM OLDUĞU İÇİN BASE CLASS OLAN(KUS) CLASSINDAKİ TANİT METHODUNU ÇALIŞTIRIYORUZ.
		}
	}
}
