

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();

            people = ConsoleMessages.GetAllPeople();

            ConsoleMessages.PrintMailingLabels(people);

            Console.Read();
        }
    }
}