

//Create classRoster List to hold student Names
List<string> classRoster = new List<string>();

do
{

    Console.Write("Enter name of student: ");
    string? studentName = Console.ReadLine();

    classRoster.Add(studentName);

    string? response = null;
    do
    {
        Console.Write("Is there anymore students (y/n): ");
        response = Console.ReadLine();
    } while (response.ToLower() != "y" && response.ToLower() != "n");

    if (response.ToLower() == "n")
    {
        break;
    }

} while (true);

Console.WriteLine($"There are {classRoster.Count} student(s)");

Console.WriteLine("Press any key to continue...");
Console.Read();
