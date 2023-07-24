namespace Destructor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* BİR CLASS'TAN ÜRETİLMİŞ OLAN NESNE İMHA EDİLİRKEN OTOMATİK ÇAĞRILAN METHODDUR. */
			x();
			GC.Collect(); //GARBAGE COLLECTOR ÇAĞIRDIK !
			Console.ReadLine();
		}
		static void x() 
		{
			Myclass myclass = new Myclass();
		}
			
		class Myclass 
		{

            public Myclass()
			{
				Console.WriteLine("SA");
			}
			~Myclass() 
			{
				Console.WriteLine("İŞTE GİDİYORUM......");
            }
        }
		/*
		 * -----------------------------------EKRAN ÇIKTISI-------------------------------------------- *
		 SA
         İŞTE GİDİYORUM...... 
		 */
	}
}