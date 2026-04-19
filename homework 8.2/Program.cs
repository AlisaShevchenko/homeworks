// Task 1
int[] array = { 8, 4, 7, 1, 9, 6 };
int n = array.Length;
int firstLargestElement = array[0];
int secondLargestElement = int.MinValue;

for (int i = 0; i < n; i++)
{
    if (array[i] > firstLargestElement)
    {
        secondLargestElement = firstLargestElement;
        firstLargestElement = array[i];
    }
    else if (array[i] < firstLargestElement && array[i] > secondLargestElement)
        {
        secondLargestElement = array[i];
        }
}

Console.WriteLine($"The second greatest element in the array is {secondLargestElement}");

// Task 2

int[,] array =
{
    { 2, 6, 1 },
    { 5, 3, 4 },
    { 6, 9, 7}
};
int rows = array.GetLength(0);
int cols = array.GetLength(1);
int[] flatArray = new int[rows * cols];
int k = 0;

for (int i = 0; i < rows; i++)
{
    for (int j =  0; j < cols; j++)
        {
        flatArray[k] = array[i, j];
        k++;
        }
}

for (int i = 0; i < flatArray.Length - 1; i++)
{
    bool swapped = false;
    for (int j = 0; j < flatArray.Length - i - 1; j++) 
    {
        if (flatArray[j] > flatArray[j + 1]) 
        {
            int temp = flatArray[j];
            flatArray[j] = flatArray[j + 1];
            flatArray[j + 1] = temp;
            swapped = true;
        }
    }
    if (!swapped) break;
}

k = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = flatArray[k];
        k++;
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

//Task 3

int[] array = {8, 4, 7, 1, 9, 6};
foreach (int i in array)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.Write("Enter the index of the array: ");
int input;

while (!int.TryParse(Console.ReadLine(), out input) || (input < 0 || input >= array.Length))
{
    Console.WriteLine($"Please enter a number between 0 and {array.Length-1}");
    Console.Write("Enter the index of the array: ");
}

int[] newArray =  new int[array.Length-1];

int index = 0;
for (int i = 0; i < array.Length; i++)
{
    if(i == input)
        continue;
    else
    {
        newArray[index] = array[i];
        index++;
    }
}
foreach (int i in newArray)
{
    Console.Write(i + " ");
}


//Task 4
int[,] array =
{
    { 7, 6, 8 },
    { 5, 3, 9 },
    { 2, 7, 10 },
};

int rows = array.GetLength(0);
int cols = array.GetLength(1);

int sumMain = 0;
int sumAnti = 0;

for (int i = 0; i < rows; i++) 
{
    sumMain += array[i, i];
    sumAnti += array[i, cols - 1 - i];
}

Console.WriteLine($"The sum of the main diagonal is: {sumMain}");
Console.WriteLine($"The sum of the anti-diagonal is: {sumAnti}");