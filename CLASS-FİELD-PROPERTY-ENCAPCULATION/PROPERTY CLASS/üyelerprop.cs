using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeclass
{
	internal class üyelerprop
	{
        public string ÜyeAdi { get; set; }
        public string ÜyeSoyadi  { get; set; }
        //Burada tanımladığımız ÜyeAdi ve ÜyeSoyadi birer propertydir.Fieldlar bu class'ta tanımlanmamıştır ama Visual Studio Derleyicisi tarafından full olmayan standart
        //Property tanımladığımızda bunlarda aynı fullproperty'de tanımladığımız fieldlar gibi çalışmaktadır.Sanal bir field tanımlayarak gelen veriyi sorgusuz şekilde
        //oraya atar ve giden veriyide sorgusuz şekilde gönderir.
    }
}
