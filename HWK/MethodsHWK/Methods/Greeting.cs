using System;
namespace Methods
{
	public static class Greeting
	{
		public static void WelcomeUser()
		{
			Console.WriteLine("Welcome to the Greeting Application");
		}

		public static string? GetFirstName()
		{
			Console.Write("What is your name: ");
			string? firstName = Console.ReadLine();

			return firstName;
		}

		public static void SayHello(string? firstName)
		{
			Console.WriteLine($"Hello {firstName}");
		}
	}
}

