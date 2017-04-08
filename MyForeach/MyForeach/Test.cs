using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForeach
{
	public class Test
	{
		private readonly int _something = 6;
		public string Some { get; set; }

		public char Do()
		{
			return 'c';
		}

		public override string ToString()
		{
			return $"{Do()} {_something}";
		}
	}
}
