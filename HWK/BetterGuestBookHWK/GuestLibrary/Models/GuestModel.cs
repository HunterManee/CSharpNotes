﻿using System;
namespace GuestLibrary.Models
{
	public class GuestModel
	{

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public string MessageToHost { get; set; }

		public string GuestInfo
		{
			get
			{
				return $"{FirstName} {LastName}: {MessageToHost}";
			}
		}
	}
}

