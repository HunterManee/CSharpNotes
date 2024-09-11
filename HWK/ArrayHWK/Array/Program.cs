

string[] names = new string[] {"Joe", "Andrew", "Madre" };

int selectedNumber;
bool isValidSlection = false;

do
{
    Console.Write("Pick a number in the range of 0-2: ");
    string? selectedText = Console.ReadLine();

    isValidSlection = int.TryParse(selectedText, out selectedNumber);
    if (isValidSlection)
    {
        if(selectedNumber < 0 || selectedNumber >= names.Length)
        {
            isValidSlection = false;
            Console.WriteLine("Invalid Number, Selection must be between 0-2");
        }
    }
    else
    {
        Console.WriteLine("Invalid Number, only whole numbers using the digit keys");
    }

} while (isValidSlection == false);

Console.WriteLine($"The given name at position {selectedNumber} is {names[selectedNumber]}.");
Console.Read();

