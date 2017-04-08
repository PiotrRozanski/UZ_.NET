using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
	public class Controller
	{
		List<Model> models = new List<Model>();
		private int id;

		public void SaveToDatabase()
		{
			Console.WriteLine("podaj telefon");
			var telephone = Console.ReadLine();
			Console.WriteLine("podaj imie");
			var name = Console.ReadLine();
			Console.WriteLine("podaj nazwisko");
			var surname = Console.ReadLine(); ;
			Console.WriteLine("podaj adres");
			var address = Console.ReadLine();
			Console.WriteLine("podaj karte");
			var creditCard = Console.ReadLine(); 
			models.Add(new Model(telephone,name,surname,address,creditCard,id.ToString()));
			id++;
		}

		public void ReadDataBase()
		{
			if (models.Count == 0)
			{
				Console.WriteLine("Brak osob w bazie");
				return;
			}

			foreach (var model in models)
			{
				Console.WriteLine("ID: ");
				Console.WriteLine(model.ID);
				Console.WriteLine("Name: ");
				Console.WriteLine(model.Name);
				Console.WriteLine("Surname: ");
				Console.WriteLine(model.Surname);
				Console.WriteLine("Credit Card: ");
				Console.WriteLine(model.CreditCardNumber);
				Console.WriteLine("Telephone: ");
				Console.WriteLine(model.Telephone);
				Console.WriteLine("Address: ");
				Console.WriteLine(model.Address);
				Console.WriteLine("-------------------------------\n");
			}
		}

	}
}
