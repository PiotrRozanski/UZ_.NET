using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPValidator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Podaj Ip");
			string ip = Console.ReadLine();
			var validator = new Validator();
			validator.ValidateIP(ip);
			Console.ReadKey();
			Console.WriteLine("Podaj Email");
			string email = Console.ReadLine();
			validator.ValidateMail(email);
		}
	}
}
