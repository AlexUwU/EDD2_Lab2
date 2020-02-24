using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2_ArboEnDisco_Gaseosas.Models
{
    public class Data
    {
		private static Data _instance = null;
		public static Data Instance
		{
			get
			{
				if (_instance == null) _instance = new Data();
				return _instance;
			}
		}

		ArbolBAsterisk<Gaseosa> arbol = new ArbolBAsterisk<Gaseosa>(5, "C://microSQL//arbolesb//" + "gaseosa" + ".arbol", new CreateGaseosa());
		public List<Gaseosa> data1 = new List<Gaseosa>();
		public List<Gaseosa> data2 = new List<Gaseosa>();
	}
}
