using Exceptions;


try
{
    OtherClass.throwException();
}
catch(MemberAccessException ex)
{
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("Practicing");
}

Console.ReadLine();
