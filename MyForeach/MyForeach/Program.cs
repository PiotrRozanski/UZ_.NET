using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int>
            {
                1,2,3,7,6,2,5,7,77
            };

            var myList2 = new List<string>
            {
                "1","18","99"
            };

	        var tests = new List<Test>()
	        {
		        new Test()
		        {
			        some = "123",
		        }
	        };

	        foreach (var v in MyLoop<string>.MyForeach(myList2))
	        {
		        var result = v.ToList();
		        for (int i = 0; i < result.Count; i++)
		        {
					Console.WriteLine(result[i]);  //tutaj robimy ostatnia operacje na najmniejszej jednostce o indeksie i
				}
	        }


			//MyLoop<Test>.MyForeach(tests);
			//MyLoop<Identcode>.MyForeach(tests2);
			//var tests2 = new Identcode[1];
			//tests2[0] = new Identcode();
			Console.ReadKey();
        }
    }
}
