namespace ReadOnlyKeyword
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyClass myClass = new MyClass();
			myClass.x = 5; //YANLIŞ KULLANIM !
			Console.WriteLine(myClass.x); //SADECE OKUNABİLİR.
			Console.ReadLine();
        }
	}
	class MyClass
	{
		public readonly int x = 5; //READONLY TANIMLAMA NOKTASINDA DEĞER ATAMASI YAPILABİLİR.
		public MyClass()
		{
			x = 15; //READONLY CONSTRUCTOR'DA ATAMA YAPILABİLİR. 
		}
		//BUNLARIN İKİSİ HARİÇ HİÇBİR YERDE ATAMA YAPILAMAZ.
		public void X() 
		{
			x = 155; //YANLIŞ KULLANIM ! READONLY AYNI CLASS'TA BİLE OLSA ATAMA YAPILAMAZ.
		}
		
    }
}