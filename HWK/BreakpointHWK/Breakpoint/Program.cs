

for(int i = 1; i <= 100; i++)
{
    if(i == 73)
    {
        throw new Exception("You at number 73");
    }
    else
    {
        Console.WriteLine($"Current Number: {i}");
    }
}

Console.Read();

