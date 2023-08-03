namespace Abstraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("");
		}
	}
	abstract class MyClass  //ABSTRACT BİR CLASS TANIMLADIK.
	{
		public abstract void Tanit(); //ABSTRACT BİR METHOD BELİRLEDİK
		public abstract void Onayla(); //ABSTRACT BİR METHOD BELİRLEDİK

	}
	class Myclass2 : MyClass //ABSTRACT OLAN CLASS'I IMPLEMENT ETTİRDİK.
	{
		public override void Onayla() //TANIMLANMIŞ OLAN ABSTRACT CLASS'I OVERRİDE EDEREK BULUNDUĞU CLASS'A UYGUN OLARAK TAMAMLADIK.
		{
			Console.WriteLine("Tanıtım Onaylandı");
		}

		public override void Tanit()
		{
            Console.WriteLine("Merhaba Ben Koray Bapoğlu");
        }
	}
	class Myclass3 : MyClass //TANIMLANMIŞ OLAN ABSTRACT CLASS'I OVERRİDE EDEREK BULUNDUĞU CLASS'A UYGUN OLARAK TAMAMLADIK.
	{
		public override void Onayla()
		{
			Console.WriteLine("Tanıtım Onaylanmadı !");
		}

		public override void Tanit()
		{
			Console.WriteLine("Hava Nasıl ?");
		}
	}
}