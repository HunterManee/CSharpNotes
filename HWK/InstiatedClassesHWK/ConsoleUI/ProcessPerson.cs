using System;
namespace ConsoleUI
{
	public static class ProcessPerson
	{
		public static PersonModel CreateNewPerson()
		{
			PersonModel person = new PersonModel();

			person.FirstName = FetchData.GetAString("What is your first name (type exit to quit): ");
			if(person.FirstName == "exit")
			{
				return person;
			}

            person.LastName = FetchData.GetAString("What is your last name: ");

			person.HomeAddress = CreateNewAddress(person.FirstName);

			return person;

        }

        private static AddressModel CreateNewAddress(string firstName)
		{
			AddressModel address = new AddressModel();

			address.StreetAddress = FetchData.GetAString($"Enter is {firstName}'s street address: ");
			address.CityName = FetchData.GetAString("What city is that in: ");
			address.StateName = FetchData.GetAString($"What state is {address.CityName} in: ");
			address.ZipCode = FetchData.GetAnInt($"What is the zip code for {address.CityName}, {address.StateName}: ");

			return address;

		}
	}
}

