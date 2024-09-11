using System;
namespace PeopleLibrary
{
	public class PersonModel
	{
		public string FirstName { private get; set; }
		public string LastName { private get; set; }

		public string GetFullName()
		{
			string output = $"{FirstName} {LastName}";

			return output;
		}
	}
}

