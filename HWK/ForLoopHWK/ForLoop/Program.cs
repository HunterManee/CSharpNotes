

Console.Write("Create a list of names seperated by commas with no spaces: \n\t");
string? nameListTxt = Console.ReadLine();

string[] firstNames = nameListTxt.Split(',').ToArray();

for(int i = 0; i < firstNames.Length; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}");
}

Console.WriteLine("Press any key to continue...");
Console.Read();
