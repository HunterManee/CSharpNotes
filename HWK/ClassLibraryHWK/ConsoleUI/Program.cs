using PeopleLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "Hunter";
            person.LastName = "Manee";

            Console.WriteLine(person.GetFullName());

            Console.Read();
        }
    }
}

