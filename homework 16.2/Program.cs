Console.Write("Enter the number: ");
double number;
while (true)
{ 
    try
    {
        string input = Console.ReadLine();
        if (!double.TryParse(input, out number))
        {
            throw new NotANumberException("Not a number. Please try again.");
        }
        Console.WriteLine($"Success! Your number is {number}");
        break;
    }
    catch (NotANumberException e)
    {
        Console.WriteLine($"Error: {e.Message}");
        Console.Write("Enter the number: ");
    }
}

public class NotANumberException : Exception
{
    public NotANumberException(string message) : base(message) { }
}