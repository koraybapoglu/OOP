namespace ThisKeyword
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyClass yeniclass = new MyClass(06, "Koray", 06); //BURADA EN SONDA BULUNAN OVERLOADU ÇAĞIRMAMIZA RAĞMEN İLK OLARAK HİÇ PARAMETRE ALMAYAN CONSTRUCTOR ARDINDAN TEK PARAMETRE ALAN CONSTRUCTOR ARDINDAN İKİ PARAMETRE ALAN CONSTRUCTOR VE EN SONDA ÇAĞIRDIĞIMIZ CONSTRUCTOR ÇALIŞTI. NEDENİ İSE THİS KEYWORD'U SAYESİNDE CONSTRUCTORLAR ARASI ZIPLAMA YAPMIŞ OLDUK.

			//THİS KEYWORD'Ü BULUNDUĞU CLASS ÜZERİNDEKİ İLGİLİ CONSTRUCTOR,PROPERTY,FİELD VB. OLAYLARA ERİŞEBİLİR.
			Console.ReadLine();
		}
		/* --------------------------------------------------EKRAN ÇIKTISI-----------------------------------------------------------
		    
		    Boş Overload Çalıştı
            int parametresi alan overload çalıştı
            int ve string parametresi alan overload çalıştı
            int,string ve int parametresi alan overload çalıştı  
		  */
	}
}
class MyClass
{
	public MyClass()
	{
		Console.WriteLine("Boş Overload Çalıştı");
	}
	public MyClass(int a) : this()
	{
		Console.WriteLine("int parametresi alan overload çalıştı");
	}
	public MyClass(int a, string b) : this(a)
	{
		Console.WriteLine("int ve string parametresi alan overload çalıştı");
	}
	public MyClass(int a, string b, int c) : this(a, b)
	{
		Console.WriteLine("int,string ve int parametresi alan overload çalıştı");
	}
}