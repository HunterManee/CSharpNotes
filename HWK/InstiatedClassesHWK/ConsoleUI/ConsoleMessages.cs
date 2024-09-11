using System;
namespace ConsoleUI
{
	public class ConsoleMessages
	{
		public static List<PersonModel> GetAllPeople()
		{
			List<PersonModel> people = new List<PersonModel>();

			PersonModel person = new PersonModel();

			do
			{
				person = ProcessPerson.CreateNewPerson();

				if(person.FirstName != "exit")
				{
					people.Add(person);
				}

			} while (person.FirstName != "exit");

			return people;
		}

		public static void PrintMailingLabels(List<PersonModel> people)
		{
			Console.Clear();

			foreach(PersonModel person in people)
			{
				Console.WriteLine($"{person.FirstName} {person.LastName}");
				Console.WriteLine($"{person.HomeAddress.StreetAddress}");
				Console.WriteLine($"{person.HomeAddress.CityName}, {person.HomeAddress.StateName}");
				Console.WriteLine($"{person.HomeAddress.ZipCode}");
				Console.WriteLine();
			}
		}
	}
}

