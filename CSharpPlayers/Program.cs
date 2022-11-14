// Challenge: Buying Inventory + Challenge: Discounted Inventory



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
Console.WriteLine("What is your name? ");
string name = Console.ReadLine().ToLower();

float discount = name == "jordan" ? 2 : 1;

var rope = 10 / discount;
var torches = 15 / discount;
var climbingEquipment = 25 / discount;
var cleanWater = 1 / discount;
var machete = 20 / discount;
var canoe = 200 / discount;
var foodSupplies = 1 / discount;

switch (input)
{
    case 1: Console.WriteLine($"Rope: {rope} gold");
        break;
    case 2: Console.WriteLine($"Torches: {torches} gold");
        break;
    case 3: Console.WriteLine($"Climbing Equipment: {climbingEquipment} gold");
        break;
    case 4: Console.WriteLine($"Clean Water: {cleanWater} gold");
        break;
    case 5: Console.WriteLine($"Machete: {machete} gold");
        break;
    case 6: Console.WriteLine($"Canoe: {canoe} gold");
        break;
    default: Console.WriteLine($"Food Supplies: {foodSupplies} gold");
        break;
}

    


