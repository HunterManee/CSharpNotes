

string? firstName = "Hunter";

int? age = 25;

bool? livingStatus = true;

string? phoneNumber = "9892454309";
if (phoneNumber != null)
{
    phoneNumber = phoneNumber.Insert(0, "(");
    phoneNumber = phoneNumber.Insert(4, ")");
    phoneNumber = phoneNumber.Insert(8, "-");
}

Console.WriteLine($"Name:        {firstName}");
Console.WriteLine($"Age:         {age}");
Console.WriteLine($"Living:      {livingStatus}");
Console.WriteLine($"PhoneNumber: {phoneNumber}");

Console.ReadLine();