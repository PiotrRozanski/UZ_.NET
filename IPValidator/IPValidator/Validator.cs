using System;
using System.Net;
using System.Text.RegularExpressions;

namespace IPValidator
{
	public class Validator
	{
		public void ValidateIP(string iPaddress)
		{
			try
			{
				var address = IPAddress.Parse(iPaddress);
				Console.WriteLine("dobry adres");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("Zly format IP");
			}
		}

		public void ValidateMail(string email)
		{
			var regex =new Regex("^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&\'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$");
			Console.WriteLine(regex.IsMatch(email) ? "Podales Email" : "To nie jest email");
			Console.ReadKey();
		}
	}
}