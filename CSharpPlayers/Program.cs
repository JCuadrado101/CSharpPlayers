// Challenge: The Defense of Consolas

Console.Title = "Defense of Consolas";

Console.Clear();
Console.WriteLine("Where is the next attack?");

Console.WriteLine("Target Row?");
int targetRow = int.Parse(Console.ReadLine());
Console.WriteLine("Target Column?");
int targetColumn = int.Parse(Console.ReadLine());

Console.WriteLine("Deploy To:");

Console.WriteLine($"({targetRow}, {targetColumn - 1})");
Console.WriteLine($"({targetRow + -1}, {targetColumn })");
Console.WriteLine($"({targetRow}, {targetColumn + 1})");
Console.WriteLine($"({targetRow + 1}, {targetColumn})");
