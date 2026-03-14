// ДЗ 4.1. Назва дня тижня

Console.Write("Enter a number for the day of the week (1-7): ");
string input = Console.ReadLine();
if (int.TryParse(input, out int numberOfDays))
{
    switch (numberOfDays)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("You entered an invalid number.");
            break;
    }
}
else
{
    Console.WriteLine("Please enter a valid number.");
}