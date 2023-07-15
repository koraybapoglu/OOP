using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoproperty
{
	public class üyebilgileri
	{
		public string ÜyeAdi { get; set; } = "Koray";
		public string ÜyeSoyadi { get; set; } = "Bapoğlu";
		int s1 = 5;
		int s2 = 10;
		/* COMPUTED PROPERTY */
		public int Topla
		{
			get
			{
				return s1 + s2;
			}
		}
	}
}
