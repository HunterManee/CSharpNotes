

string? firstName = null;


do
{
    Console.Write("What is your name: ");
    firstName = Console.ReadLine();

    if (firstName.ToLower() != "exit")
    {
        string? formattedName = null;
        switch (firstName.ToLower())
        {
            case "tim":
                formattedName = $"Professor, {firstName}";
                break;

            default:
                formattedName = $"Student, {firstName}";
                break;
        }

        Console.WriteLine($"Welcome, {formattedName}.");
    }


} while (firstName.ToLower() != "exit");

Console.Write("Press any key to continue...");
Console.Read();