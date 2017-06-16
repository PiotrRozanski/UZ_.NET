using System.Collections.Generic;
using System.Linq;
using NetCoreTest.Models;

namespace NetCoreTest
{
    public class DatabaseController
    {
	    public void AddNewPersonToPhoneBook(string name, string telephone)
	    {
		   using (var context = new D__DEMODB_MDFContext())
		   {
			  var t = new PhoneBook()
			  {
			   Person = name,
			   TelephoneNumber = telephone,
			  };
			  context.PhoneBook.Add(t);
			  context.SaveChanges();
		   }
		}

		public List<PhoneBook> FindPersonByTelephone(string telephone)
	    {
		    using (var context = new D__DEMODB_MDFContext())
		    {
				//mozna z LINQ-u uzyc first abby wyciagnac pierwszy o takim numerze telefonu
			    var items = context.PhoneBook.Where(x => x.TelephoneNumber == telephone).ToList(); ;
			    return items;
		    }
	    }

		public List<PhoneBook> FindTelephoneByPerson(string person)
	    {
		    using (var context = new D__DEMODB_MDFContext())
		    {
			    var items = context.PhoneBook.Where(x => x.Person == person).ToList(); ;
			    return items;
		    }
	    }

	    public List<string> GetAllEmails()
	    {
			var emailsList = new List<string>();
			using (var context = new D__DEMODB_MDFContext())
			{
				var emails = context.Emails.ToList(); ;
				emailsList.AddRange(emails.Select(email => email.Email));
			}
		    return emailsList;
	    }
	}
}
