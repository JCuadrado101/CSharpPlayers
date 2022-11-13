// Challenge: Repairing the Clocktower

Console.WriteLine("Enter a minute for the clock tower.");
int minute = int.Parse(Console.ReadLine());

if (minute % 2 == 0)
{
    Console.WriteLine("Tick");
}
Console.WriteLine("Tock");

// Challenge: Watchtower

Console.WriteLine("Enter X position");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y position");
int y = int.Parse(Console.ReadLine());

if (x < 0 && y > 0)
{
    Console.WriteLine("Enemy is NW!");
}
else if (x == 0 && y > 0)
{
    Console.WriteLine("Enemy is N!");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Enemy is NE!");
}
else if (x < 0 && y == 0)
{
    Console.WriteLine("Enemy is W!");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("Enemy is here!");
}
else if (x > 0 && y == 0)
{
    Console.WriteLine("Enemy is E!");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Enemy is SW!");
}
else if (x == 0 && y < 0)
{
    Console.WriteLine("Enemy is S!");
} 
else if (x > 0 && y < 0)
{
    Console.WriteLine("Enemy is SE!");
}