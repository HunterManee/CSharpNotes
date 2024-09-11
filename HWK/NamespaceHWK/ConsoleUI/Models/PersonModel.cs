using System;

namespace DataStructure
{
	public class PersonModel
	{
		private string _firstName;

		public PersonModel(string firstName)
		{
			_firstName = firstName;
		}

		public string getName()
		{
			return _firstName;
		}

	}
}

