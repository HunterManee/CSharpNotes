using DataStructure;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Hunter");

            Console.WriteLine(person.getName());

            Console.Read();
        }
    }
}