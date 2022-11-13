// Challenge: Buying Inventory

Console.WriteLine(
    "The following items are available: \n " +
    "1 - Rope \n " +
    "2 - Torches \n " +
    "3 - Climbing Equipment \n " +
    "4 - Clean Water \n " +
    "5 - Machete \n " +
    "6 - Canoe \n" +
    "7 - Food Supplies \n"
    );

Console.Write("What numbers do you want to see the price of? ");
int input = int.Parse(Console.ReadLine());

switch (input)
{
    case 1: Console.WriteLine("Rope: 10 gold");
        break;
    case 2: Console.WriteLine("Torches: 15 gold");
        break;
    case 3: Console.WriteLine("Climbing Equipment: 25 gold");
        break;
    case 4: Console.WriteLine("Clean Water: 1 gold");
        break;
    case 5: Console.WriteLine("Machete: 20 gold");
        break;
    case 6: Console.WriteLine("Canoe: 200 gold");
        break;
    default: Console.WriteLine("Food Supplies: 1 gold");
        break;
}

    
