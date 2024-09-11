

namespace ExtentionMethodHWK
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.SetDefaultAge().PrintPersonInfo();

            Console.Read();
        }
    }

    //When creating extention methods they can not be within the model that your working with
    public class PersonModel
    {
        public string FirstName { get; set; } = "Hunter";
        public string LastName { get; set; } = "Manee";

        public string Age { get; set; }

    }

    public static class ExtentionMethods
    {
        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = "25";
            return person;
        }


        public static void PrintPersonInfo(this PersonModel person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
            Console.WriteLine($"Default Age: {person.Age}");
        }
    }
}

