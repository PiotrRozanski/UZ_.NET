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
            List<int> myList = new List<int>
            {
                1,2,3,7,6,2,5,7,77
            };

            List<string> myList2 = new List<string>
            {
                "1","18","99"
            };

            MyLoop<int>.MyForeach(myList);
            MyLoop<string>.MyForeach(myList2);

            Console.ReadKey();

        }
    }
}
