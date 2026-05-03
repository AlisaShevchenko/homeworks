double firstNumber =  ReadDouble("Enter the first number: ");
double secondNumber = ReadDouble("Enter second number: ");

try
{
    if (secondNumber == 0)
    {
        throw new DivisorEqualZeroException("Error: You can't divide by zero!");
    }

    double result = firstNumber / secondNumber;
    Console.WriteLine($"The result is {result}");
}
catch (DivisorEqualZeroException e)
{
    Console.WriteLine(e.Message);
}
static double ReadDouble (string message)
{
    double number;
    Console.Write(message);
    while (!double.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input! Please enter a valid numeric value.");
        Console.Write(message);
    }
    return number;
}

public class DivisorEqualZeroException : Exception
{
    public DivisorEqualZeroException(string message) : base(message)
    {
    }
}
