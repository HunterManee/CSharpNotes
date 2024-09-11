

Console.Write("What is your name: ");
string? firstName = Console.ReadLine();

switch (firstName.ToLower())
{
    case "timothy":
    case "tim":// or "timothy":
        Console.WriteLine("Hello Professor");
        break;
    default:
        Console.WriteLine("Hello Student");
        break;
}

if(firstName.ToLower() == "tim" || firstName.ToLower() == "timothy")
{
    Console.WriteLine("Hello Professor");
}
else
{
    Console.WriteLine("Hello Student");
}

Console.Read();