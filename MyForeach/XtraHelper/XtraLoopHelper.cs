using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace XtraHelper
{
	public static class XtraLoopHelper<T>
	{
		private static T[] _genericArray;

		private static void SetGenericValue(ICollection<T> collection)
		{
			_genericArray = collection.ToArray();
		}

		private static IEnumerable<T> GetOutArray()
		{
			IEnumerator iterator = _genericArray.GetEnumerator();
			while (iterator.MoveNext())
			{
				var element = (T)iterator.Current;
				yield return element;
			}
		}

		public static IEnumerable<IEnumerable<T>> MyForeach(ICollection<T> collection)
		{
			SetGenericValue(collection);
			yield return GetOutArray();
		}

	}
}