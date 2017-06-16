using System;
using System.Data.Common;

namespace NetCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
	        try
	        {
				var dbc = new DatabaseController();
				//dbc.AddNewPersonToPhoneBook("Misiu Pysiu","999929992");
		        //var telephones = dbc.FindTelephoneByPerson("Misiu Pysiu");
		        var persons = dbc.FindPersonByTelephone("999929992");
		        if (persons.Count > 0)
		        {
					foreach (var person in persons)
			        {
				        Console.WriteLine(person.Person);
			        }
			        Console.ReadKey();
				}
		        else
		        {
			        Console.WriteLine("Brak Osob o takim numerze");
		        }

		        foreach (var email in dbc.GetAllEmails())
		        {
					Console.WriteLine($"Wysyłam Maila do: {0}", email);
				}
				
	        }
	        catch (DbException e)
	        {
		        Console.WriteLine(e);
		        throw;
	        }
        }
    }
}