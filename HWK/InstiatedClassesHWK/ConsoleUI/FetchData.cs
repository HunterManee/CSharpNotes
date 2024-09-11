using System;
namespace ConsoleUI
{
	public class FetchData
	{
        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }

        public static int GetAnInt(string message)
        {
            string intText = GetAString(message);
            int output = 0;

            bool isValidNumber = int.TryParse(intText, out output);
            while (isValidNumber == false)
            {
                Console.WriteLine("Invalid Number. Try using number pad");

                intText = GetAString(message);
                isValidNumber = int.TryParse(intText, out output);
            }

            return output;
        }
    }
}

