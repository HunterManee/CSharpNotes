

//Get the user's age
Console.Write("What is your current age: ");
string? ageText = Console.ReadLine();

//Type Conversition
int.TryParse(ageText, out int age);

//Add 25 years to their age
Console.WriteLine($"You will be {age + 25} in 25 years");


//Subtract 25 years from their age
Console.WriteLine($"You were {age - 25}, 25 years ago");

Console.ReadLine();