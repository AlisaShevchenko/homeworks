/*//Task 9.1

Console.Write("Enter your name and surname: ");
string input = Console.ReadLine();
string[] array = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
if (array.Length < 2)
{
    Console.WriteLine("Please enter both name and surname");
    return;
}
string name = array[0];
string lastName = array[1];

if(char.ToLower(name[0]) == char.ToLower(lastName[0]))
{
    Console.WriteLine("Last name starts with the same letter as first name");
}
else
{
    Console.WriteLine("The last name does not start with the same letter as the first name");
}

// Task 9.2


using System.Dynamic;
using System.Text;
Console.WriteLine("Please enter the events");

StringBuilder report = new StringBuilder();

Console.WriteLine("---Report Generation---");
Console.Write("Enter report title: ");
string title = Console.ReadLine();

report.AppendLine("Title: " + title);
Console.Write("Enter report date (dd.mm.yyyy): ");
string date = Console.ReadLine();
report.AppendLine("Date: " + date);
Console.WriteLine("Enter report event (type 'save' to finish): ");

report.AppendLine("Events:");
while (true)
{
    Console.Write("Event: ");
    string events = Console.ReadLine();
    if (events.ToLower() == "save")
        break;
    if (!string.IsNullOrWhiteSpace(events))
    {
        report.AppendLine("- " + events);
    }
}
Console.WriteLine();
Console.WriteLine("===Your finale report===");
Console.Write(report.ToString());
Console.WriteLine("------------------------");


// Task 9.3
string words = "apple, orange, blueberry, banana";
string noSpaces = words.Replace(" ", "");
Console.WriteLine($"Result: {noSpaces}");*/

using System.Text;

Console.Write("Enter your text: ");

StringBuilder sb = new StringBuilder();

string input = Console.ReadLine();
string[] array = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length > 3)
    {
        sb.Append(array[i]);
        sb.Append(" ");
    }
}
Console.WriteLine(sb.ToString());