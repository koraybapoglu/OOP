using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	internal class Insan
	{
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yasi { get; set; }
        public virtual string Cinsiyet { get; set; }
        public virtual void Tanit() 
        {
            Console.WriteLine("Ben bir İnsanım");
        }
    }
}
