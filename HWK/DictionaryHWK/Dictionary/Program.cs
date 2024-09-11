

Dictionary<int, string> employeeID = new Dictionary<int, string>();

employeeID[1] = "Hunter Manee";
employeeID[2] = "Tim Corey";
employeeID[3] = "Sue Storm";
employeeID[4] = "Andrew Manee";
employeeID[5] = "John Wick";
employeeID[6] = "John Jacob Jingle Himmer Shmit";
employeeID[7] = "His Name is my name too";
employeeID[8] = "Jessica Lowery";

Console.Write("Enter in your id: ");
string? idText = Console.ReadLine();

if(int.TryParse(idText, out int id))
{
    if (employeeID.ContainsKey(id))
    {
        Console.WriteLine(employeeID[id]);
    }
    else
    {
        Console.WriteLine("Invalid ID");
    }
}
else
{
    Console.WriteLine("Invalid ID");
}

Console.WriteLine("Press any key to continue...");
Console.Read();

