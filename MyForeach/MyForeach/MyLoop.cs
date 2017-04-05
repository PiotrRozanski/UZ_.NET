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
        private static T[] genericArray;

        public MyLoop(int size)
        {
            genericArray = new T[size + 1];
        }

        public MyLoop()
        {
        }

        private static void SetGenericValue(ICollection<T> collection)
        {
            genericArray = collection.ToArray<T>();
        }

        private static void PrintOutArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        internal static void MyForeach(List<T> myList)
        {
            PrintOutArray(myList.ToArray());
        }

        public T GetItem(int index)
        {
            return genericArray[index];
        }

        public static string JoinAsString<T>(T a, T b)
        {
            return a.ToString() + b.ToString();
        }

        //public static void MyForeach(ICollection<T> collection)
        //{
        //    SetGenericValue(collection);
        //    PrintOutArray(genericArray);
        //}
    }
}
