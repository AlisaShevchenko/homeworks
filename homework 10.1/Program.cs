string word = "heart";
char[] charArray = word.ToCharArray();
char[] displayArray = new char[charArray.Length];
Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
Console.WriteLine($"Кількість літер у слові:  {word.Length}");
Console.WriteLine($"Кількість можливих невірних:  {word.Length}");
for (int i = 0; i < displayArray.Length; i++)
{
    displayArray[i] = '*';
    Console.Write(displayArray[i]);
}
Console.WriteLine();

bool rightAnswer = false;
int attemptsCounter = 0;
string positions= "";
string currentProgress = new string(displayArray);

while (attemptsCounter <= word.Length )
{
    rightAnswer = false;
    Console.Write("Введіть вашу літеру: ");
    char letter = char.ToLower(Console.ReadLine()[0]);
    if (new string(displayArray).Contains(letter)) 
    {
        Console.WriteLine("Ви вже відгадали цю літеру!");
        continue; 
    }
    {
        positions = "";
        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.ToLower(charArray[i]) == letter)
            {
                displayArray[i] = letter;
                positions += (i + 1) + " "; 
                if (new string(displayArray) == word)
                {
                    Console.WriteLine("Ви перемогли!");
                    return;
                }
                rightAnswer  = true;
            }
        }
        if (rightAnswer)
        {
            Console.WriteLine($"Така літера є у слові! Позиція літери: {positions}"); 
            Console.WriteLine(new string(displayArray));
        }
        else
        {
            Console.WriteLine($"Такої літери немає! Залишилось спроб: {word.Length - attemptsCounter}");
            attemptsCounter++;
        }
    }
}
Console.WriteLine("На жаль, спроби закінчилися!");