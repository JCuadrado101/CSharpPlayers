// Challenge: Repairing the Clocktower

Console.WriteLine("Enter a minute for the clock tower.");

int minute = int.Parse(Console.ReadLine());

if (minute % 2 == 0)
{
    Console.WriteLine("Tick");
}
Console.WriteLine("Tock");