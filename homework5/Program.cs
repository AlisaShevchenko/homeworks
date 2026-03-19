//1. Обчислення середнього заробітку:

Console.Write("Enter the number of employees: ");
int employees;
while (!int.TryParse(Console.ReadLine() , out employees) || employees <= 0)
{
    Console.WriteLine("Invalid input. Enter a value greater than 0.:");
}

decimal salaryPerPerson;
decimal totalSalary = 0;
for (int i = 1; i <= employees; i++)
{
    Console.Write($"Enter the salary of employee №{i}: ");
    while (!decimal.TryParse(Console.ReadLine(), out salaryPerPerson))
    {
        Console.Write("Incorrect input. Please try again.");
    }
    totalSalary += salaryPerPerson;
}
Console.WriteLine($"The average earnings of employees are: {totalSalary/employees}");


//2. Побудова графіку зірочками: 

Console.Write("Enter the number of rows: ");
int rows;
while (!int.TryParse(Console.ReadLine() , out rows) || rows < 0)
{
    Console.WriteLine("Please enter correct number of rows: ");
}   


for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//3.Генерація простих чисел

Console.Write("Enter your number: ");
int number;
while (!int.TryParse(Console.ReadLine() , out number) || number <0)
{
    Console.WriteLine("Please enter correct number");
}

for (int i = 2; i <= number; i++)
{
    bool isPrime = true;
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    Console.WriteLine(i);


//4. Генерація фібоначчівської послідовності: 

Console.Write("Enter your number: ");
int input;
while (!int.TryParse(Console.ReadLine() , out input) || input <0)
{
    Console.WriteLine("Please enter correct number");
}

int a = 0;
int b = 1;
for (int i = 0; i < input; i++)
{
    Console.WriteLine(a);
    int sum = a + b;
    a = b;
    b = sum;
}

// 5.Калькулятор оплати праці за годину

Console.Write("Enter daily hours worked: ");
decimal hours;
while (!decimal.TryParse(Console.ReadLine() , out hours))
{
    Console.WriteLine("Please enter correct number");
}
Console.Write("Enter your hourly rate: ");
decimal hourlyRate;
while (!decimal.TryParse(Console.ReadLine() , out hourlyRate))
{
    Console.WriteLine("Please enter correct number");
}
decimal dailyRate = hours * hourlyRate;
Console.WriteLine($"The daily rate is {dailyRate:N2} euro.");

//6. Генерація таблиці множення для конкретного числа:

Console.Write("Enter your number: ");
int input;
while (!int.TryParse(Console.ReadLine() , out input) || input <0)
{
    Console.WriteLine("Please enter correct number");
}

for (int i = 1; i <= 10; i++)
{
    int multiply = input * i;
    Console.WriteLine($"{input} * {i} = {multiply}");
}

//7.Перевірка на простоту: 

Console.Write("Enter your number: ");
int input;
while (!int.TryParse(Console.ReadLine() , out input) || input <0)
{
    Console.WriteLine("Invalid input. Enter a value greater than 0.");
}
bool isPrime = true;
int squareRoot =  (int)Math.Sqrt(input);
if (input < 2)
{
    Console.WriteLine("The number is neither prime nor composite.");
}
else
{
    for (int i = 2; i <= squareRoot; i++)
    {
        if (input % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime == true)
        {
            Console.WriteLine("Prime number.");
        }
    else
    {
        Console.WriteLine("Composite number.");
    }
}