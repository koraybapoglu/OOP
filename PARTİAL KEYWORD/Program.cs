namespace PartialKeyword
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//PARTİAL KEYWORD'Ü NEDİR ?

			//PARTİAL KOD BÖLÜMLEMEYE YARAR.

			//BÜYÜK VE KARMAŞIK YAPIDAKİ SINIFLARI DAHA OKUNABİLİR VE DÜZENLENEBİLİR PARÇALARA BÖLMEK İÇİN KULLANILABİLİR.

			//İŞ BÖLÜMÜNE YARAR.

			//EKİPLERİN,AYNI SINIFIN FARKLI KISIMLARINI AYNI ANDA GELİŞTİREBİLMELERİ İÇİN KULLANILABİLİR.


			new MyClass();
			Console.ReadLine();

		}
	}
	partial class MyClass  //BU ŞEKİLDE MYCLASS SINIFINI PARTİAL KEYWORD'Ü KULLANARAK AYIRMIŞ OLDUK.
	{
        public MyClass()
        {
			X();
			Y();
        }
		public void X() 
		{
            Console.WriteLine("Kişinin Bilgileri Depoya Kaydedildi !");   
        }
    }
	partial class MyClass //BU ŞEKİLDE MYCLASS SINIFINI PARTİAL KEYWORD'Ü KULLANARAK AYIRMIŞ OLDUK.
	{
        public void Y() 
		{
            Console.WriteLine("Kişinin bilgileri Veritabanına Kaydedildi !");
        }
    }
}