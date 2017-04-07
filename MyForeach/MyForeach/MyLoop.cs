using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForeach
{
    public class MyLoop<T>
    {
        private static T[] _genericArray;

        public MyLoop(int size)
        {
            _genericArray = new T[size + 1];
        }

        public MyLoop()
        {
        }

        private static void SetGenericValue(ICollection<T> collection)
        {
            _genericArray = collection.ToArray<T>();
        }

        private static IEnumerable<T> PrintOutArray()
        {
	        IEnumerator iterator = _genericArray.GetEnumerator();
	        while (iterator.MoveNext())
	        {
		        var element = (T) iterator.Current;
		        //Console.WriteLine(element);
		        yield return element;
	        }
        }

        public T GetItem(int index)
        {
            return _genericArray[index];
        }

       public static void MyForeach(ICollection<T> collection)
       {
           SetGenericValue(collection);
           PrintOutArray();
       }
    }
}
