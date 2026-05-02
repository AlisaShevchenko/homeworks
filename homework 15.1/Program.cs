Console.Write("Введіть шлях до вихідного файлу: "); 
string sourcePath = Console.ReadLine();
Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: "); 
string destinationPath =  Console.ReadLine();
try
{
    if (File.Exists(sourcePath))
    {
        File.Copy(sourcePath, destinationPath, true);
        Console.WriteLine("Файл успішно скопійовано!");
    }
    else
    {
        Console.WriteLine("Помилка: Вихідний файл не знайдено.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Помилка: {ex.Message}");
}

