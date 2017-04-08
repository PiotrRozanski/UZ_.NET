using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
	public class Model
	{
		public Model(string telephone, string name, string surname, string address, string creditcard,string id)
		{
			Telephone = telephone;
			Name = name;
			Surname = surname;
			Address = address;
			CreditCardNumber = creditcard;
			ID = id;
		}

		public string ID { get; set; }
		public string Telephone { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
		public string CreditCardNumber { get; set; }

	}
}
