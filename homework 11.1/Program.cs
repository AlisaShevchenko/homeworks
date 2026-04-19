
Console.WriteLine("Enter input parametr");
int input;
while (!int.TryParse(Console.ReadLine(), out input) || input < 0)
{
    Console.WriteLine("The input must be a positive integer");
    Console.WriteLine("Enter input parametr");
}

long number = FibonacciHelper.GetFibonacci(input);
Console.WriteLine($"Output value: {number}");

public static class FibonacciHelper
{
    public static long GetFibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        
    }
}
