// Challenge: Simula's Test

ChestState currentState = ChestState.Locked;

while (true)
{
    Console.Write($"The chest is {currentState}. What would you like to do? ");
    string input = Console.ReadLine();

    if (currentState == ChestState.Locked && input == "unlock") currentState = ChestState.Closed;
    if (currentState == ChestState.Closed && input == "open") currentState = ChestState.Open;
    if (currentState == ChestState.Open && input == "close") currentState = ChestState.Closed;
    if (currentState == ChestState.Closed && input == "lock") currentState = ChestState.Locked;


}


enum ChestState {Open, Closed, Locked};