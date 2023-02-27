using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalTest.Class
{
	public class NewHashMap
	{
		private Dictionary<int, int> newHM;

		public void insert(int num1, int num2) {
			newHM.Add(num1, num2);
		}

		public int get(int key) {
			//search for hashmap using key
			return newHM[key];
		}

		public void addToKey(int value) {
			addValue(false,value);
		}

		public void addToValue(int value) {
			addValue(true, value);
		}

		public void addValue(bool whereToAdd, int value) {
			Dictionary<int, int> tmp = new Dictionary<int, int>();
			foreach (KeyValuePair<int, int> pair in newHM)
			{
				int tmpKey=0;
				if (whereToAdd) {
					tmpKey = pair.Value + value;
					tmp.Add(pair.Key, tmpKey);
				}else{
					tmpKey = pair.Key + value;
					tmp.Add(tmpKey, pair.Value);
				}			
			}
			newHM.Clear();
			newHM = tmp;
		}
	}
}
