using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSignalTest.Class;

namespace CodeSignalTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			NewHashMap HM = new NewHashMap();
			HM.insert(1, 2);
			HM.get(1);
			HM.addToKey(3);
			HM.addToValue(4);
		}
	}
}
