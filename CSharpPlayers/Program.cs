// Challenge: Hunting the Manticore

int cityHP = 15;
int manticoreHP = 10;
int round = 1;

Console.WriteLine("Player 1, how far away from the city do you want to station the manticore?");

int distance = int.Parse(Console.ReadLine());

Console.WriteLine("PLayer 2, it is your turn");

while (true)
{
    int guess = Math.Abs(int.Parse(Console.ReadLine()));
    Console.WriteLine("-------------------------------------------------------------------");
    Console.WriteLine($"STATUS: Round {round} City: {cityHP}/15 Manticore {manticoreHP}/10");

    if (round % 3 == 0 || round % 5 == 0)
    {
        Console.WriteLine("The cannon is expected to deal 3 damage this round.");
    }
    else
    {
        Console.WriteLine("The cannon is expected to deal 1 damage this round");

    }

    if (manticoreHP <= 0)
    {
        Console.WriteLine("City saved!");
        return;
    }
    
    if (cityHP <= 0)
    {
        Console.WriteLine("The city was destroyed - you lose");
        return;
    }
    if (distance == guess)
    {
        manticoreHP -= 3;
        cityHP -= 1;
        round++;
        Console.WriteLine("That round was a DIRECT HIT!");
    } 
    else if (distance > guess)
    {
        manticoreHP -= 1;
        cityHP -= 1;
        round++;
        Console.WriteLine("That round FELL SHORT the target.");
    }
    else
    {
        manticoreHP -= 1;
        cityHP -= 1;
        round++;
        Console.WriteLine("That round OVERSHOT the target.");
    }
    Console.Write("Enter desired cannon range: ");
}

