using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;


namespace MyForeach
{
	class Program
	{
		static void Main(string[] args)
		{
			var myList = new List<int>
			{
				1,
				2,
				3,
				7,
				6,
				2,
				5,
				7,
				77
			};

			var myList2 = new List<string>
			{
				"1",
				"18",
				"99"
			};

			var test = new List<Test>()
			{
				new Test()
				{
					Some = "123",
				}
			};

			var test2 = new Identcode[1];
			test2[0] = new Identcode();

			//var items = MyLoop<Identcode>.MyForeach(test2);
			//var items = MyLoop<Test>.MyForeach(test);
			//var items = MyLoop<int>.MyForeach(myList);
			var items = MyLoop<string>.MyForeach(myList2);

			items.ToObservable().Subscribe(i =>
			{
				var result = i.ToList();

				for (var j = 0; j < result.Count; j++)
				{
					Console.WriteLine(result[j]);
				}
			});
			Console.ReadKey();
		}
	}
}