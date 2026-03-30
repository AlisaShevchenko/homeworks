//Task 1-2.

int[] array = new int[10];
Random random = new Random();
int sum = 0;

Console.WriteLine("Even-indexed array elements:");

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 11);
    if (i % 2 == 0)
    {
        Console.WriteLine($"Index {i}: {array[i]}");
    }

    sum += array[i];
}

if (sum >= 0)
    {
        Console.WriteLine("The sum of the array elements is a non-negative number.");
    }
    else
    {
        Console.WriteLine("The sum of the array elements is not a positive number.");
    };
    // Task 3.
    
    for (int i = 1; i <= 9; i++)
    {
        for (int j = 1; j <= 9; j++)
        {
            Console.Write((i * j) + "\t");
        }
        Console.WriteLine();
    }
    
    // Task 4.

int[,] array =
{
    {4, 36, 24, 18, 52},
    {7, 32, 13, 76, 29},
    {53, 45, 31, 59, 20},
    {49, 63, 99, 78, 17},
    {85, 71, 50, 91, 4}
};

int minValue = array[0,0];
int maxValue = array[0, 0];
int maxRow = 0, maxCol = 0;
int minRow = 0, minCol = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < minValue)
        {
            minValue = array[i,j];
            minRow = i;
            minCol = j;
        }

        if (array[i, j] > maxValue)
        {
            maxValue = array[i,j];
            maxRow = i;
            maxCol = j;
        }
        
    }
}
Console.WriteLine($"Array maximum is {maxValue}");
Console.WriteLine($"Array minimum is {minValue}");
Console.WriteLine($"The index of the maximum element is [{maxRow},{maxCol}]");
Console.WriteLine($"The index of the minimum element is [{minRow},{minCol}]");

// Task 5.
     
int input;
    Console.Write("Enter the number of days: ");

    while(!(int.TryParse(Console.ReadLine(), out input)))
    {
        Console.WriteLine("Invalid input. Enter a correct number.");
    }

    int dayIndex = (input) % 7 + 1;
    WeekDays selectedDay = (WeekDays)dayIndex;
    Console.WriteLine($"The day is: {selectedDay}");

    enum WeekDays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }; 
    