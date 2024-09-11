using System;
namespace ConsoleUI
{
	public class AddressModel
	{
		public string StreetAdress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public int ZipCode { get; set; }

		public string FullAdress
		{
			get//read only
			{
				return $"{StreetAdress}\n{City}, {State}\n{ZipCode}";
			}
		}
	}
}

