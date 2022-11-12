// Challenge: The Triangle Farmer

Console.WriteLine("What is the base of the triangle? (Numbers only)");
float baseOfTriangle = float.Parse(Console.ReadLine());

Console.WriteLine("What is the height of the triangle? (Numbers only");
float heightOfTriangle = float.Parse(Console.ReadLine());

float area = (baseOfTriangle + heightOfTriangle) / 2;
Console.WriteLine("The area of the triangle is: " + area);


// Challenge: The Four Sisters and the Duckbear

int numOfSisters = 4;

Console.WriteLine("How many eggs did the chickens lay?");
int numOfChocolateEggs = int.Parse(Console.ReadLine());

Console.WriteLine("The sisters get " + numOfChocolateEggs / numOfSisters + " each");
Console.WriteLine("The Duckbear gets " + numOfChocolateEggs % numOfSisters);


