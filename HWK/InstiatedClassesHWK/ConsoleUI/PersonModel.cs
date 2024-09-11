using System;
namespace ConsoleUI
{
	public class PersonModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		//This will allow the models to be connected when making the application
		public AddressModel HomeAddress { get; set; }

	}
}

