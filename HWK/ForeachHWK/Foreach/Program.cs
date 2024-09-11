

List<string> firstNames = new();
string? firstName;


do
{
    switch (firstNames.Count)
    {

        case 0:
            Console.Write("What is your first name: ");
            break;

        default:
            Console.WriteLine("Just press enter when finished...");
            Console.Write("Give someone else name: ");
            break;
    }

    firstName = Console.ReadLine();

    if (firstName != "")
    {
        firstNames.Add(firstName);
    }
    else
    { 
        break;
    }

} while (true);

foreach (var name in firstNames)
{
    Console.WriteLine($"Hello {name}");
}

Console.WriteLine("Press any key to continue...");
Console.Read();

