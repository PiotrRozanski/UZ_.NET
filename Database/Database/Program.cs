using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
	class Program
	{
		static void Main(string[] args)
		{
			int choose;
			var ctrl = new Controller();
			do
			{
				Console.WriteLine("1.Dodaj osobe");
				Console.WriteLine("2.Pokaz baze");
				Console.WriteLine("3.Wyjdz ");
				var choosenumber = Console.ReadLine();
				int.TryParse(choosenumber, out choose);
				
				switch (choose)
				{
					case 1:
						ctrl.SaveToDatabase();
						break;
					case 2:
						ctrl.ReadDataBase();
						break;
					case 3:
						return;
				}
			} while (choose != 3);

		}
	}
}
