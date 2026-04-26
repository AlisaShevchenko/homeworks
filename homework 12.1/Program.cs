using System.ComponentModel;

class Program
{
    static List<string> MyTask = new List<string>();

    static void Main()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\n--- МЕНЮ ---");
            Console.WriteLine("1. Показати список");
            Console.WriteLine("2. Додати завдання");
            Console.WriteLine("3. Виконати завдання");
            Console.WriteLine("4. Видалити завдання");
            Console.WriteLine("0. Вихід");
            Console.Write("Оберіть дію: ");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    DisplayList(MyTask);
                    break;
                case "2":
                    Console.Write("Введіть назву завдання: ");
                    string title = Console.ReadLine();
                    AddTask(title);
                    break;
                case "3":
                    Console.Write("Введіть номер завдання: ");
                    int indexToMark = GetValidTaskNumber(); 
                    MarkTaskIsDone(indexToMark);
                    break;
                case "4":
                    Console.Write("Введіть номер завдання: ");
                    int indexToDelete = GetValidTaskNumber(); 
                    DeleteTask(indexToDelete);
                    break;
                case "0":
                    isRunning = false; 
                    Console.WriteLine("Програма завершена.");
                    break;
                default:
                    Console.WriteLine("Невідома команда.");
                    break;
                    
            }
        }
    }

    static void AddTask(string title) 
        { 
            MyTask.Add(title); 
        }
    
    static void DisplayList( List<string> tasks)
        {
            if (tasks == null) return;
            for (int i = 0; i < tasks.Count; i++)
            { 
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }  
    static void MarkTaskIsDone(int userNumber)
        {
            int index = userNumber - 1;
    
            if (index >= 0 && index < MyTask.Count)
            {
                MyTask[index] = MyTask[index]+ " -[Done]"; 
            }
            else
            {
                Console.WriteLine("Помилка: такого номера завдання не існує.");
            }
        }
    static void DeleteTask(int userNumber)
        {
            int index = userNumber - 1;
            if (index >= 0 && index < MyTask.Count)
            {
                string removedTask = MyTask[index];
                MyTask.RemoveAt(index);
                Console.WriteLine($"Завдання '{removedTask}' успішно видалено.");
            }
            else
            {
                Console.WriteLine("Помилка: завдання з таким номером не знайдено.");
            }   
        }

    static int GetValidTaskNumber()
    {
        int userNumber;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out userNumber) && userNumber >= 1 && userNumber <= MyTask.Count)
            {
                return userNumber; // Повертаємо коректне число
            }
            Console.WriteLine($"Помилка: будь ласка, введіть число від 1 до {MyTask.Count}.");
        }
    }
}

