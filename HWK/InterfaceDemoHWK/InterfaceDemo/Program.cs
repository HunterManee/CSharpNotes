

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Animal animal = new Animal();

            List<IRun> runs = new List<IRun>();

            runs.Add(person);
            runs.Add(animal);

            Console.Read();
        }
    }
}

