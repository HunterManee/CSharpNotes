using GuestLibrary.Models;

//Capture the information about each guest (assumption is at least 1 guest and unknown maximum)
//Info Capture: FirstName, LastName, Message to the host
//Once done, loop through each guest and print their info

namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {
            GetGuestInformation();

            PrintGuestInformation();

            Console.Read();
        }

        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetStringFromConsole("What is your first name: ");
                guest.LastName = GetStringFromConsole("What is your last name: ");
                guest.MessageToHost = GetStringFromConsole("What message would you like to give the host: ");
                moreGuestsComing = GetStringFromConsole("Is their any more guest coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static void PrintGuestInformation()
        {

            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        private static string GetStringFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}

