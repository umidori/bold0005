using System;
using System.Linq;
using System.Collections.Generic;

class Program {
	static void Main() {
		var list = new List<int>{1,2,3,4};
		var revList = list.OrderBy(x=>-x);

		list.Add(5);
		list.Add(6);

		foreach (var l in revList) {
			Console.WriteLine(l);
		}
	}
}
