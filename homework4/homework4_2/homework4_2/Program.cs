//ДЗ 4.2. Калькулятор

using System.Diagnostics;

Console.Write("Enter a first number: ");
int number1;
while (!int.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Enter correct number.");
}

Console.Write("Enter a second number: ");
int number2;
while (!int.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Enter a second number: ");
}
Console.Write("Enter the sign of the mathematical operation: + - * or /: ");
string sign = Console.ReadLine();

switch (sign)
{
    case "+":
        Console.WriteLine("The result is: " + (number1 + number2));
        break;
    case "-":
        Console.WriteLine("The result is: " + (number1 - number2));
        break;  
    case "*":
        Console.WriteLine("The result is: " + (number1 * number2));
        break;
    case "/":
        if (number2 != 0)
        {
            Console.WriteLine("The result is: " + (number1 / number2));
        }
        else
        {
            Console.WriteLine("You cannot divide by zero.");
        }
        break;
    default:
        Console.WriteLine("You entered an incorrect sign");
        break;
} 


