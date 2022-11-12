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

// Challenge: The Dominion of Kings

int estatePoint = 1;
int duchyPoint = 3;
int provincePoint = 6;


Console.WriteLine("How many estates do you have? ");
int totalEstatePoints = int.Parse(Console.ReadLine()) * estatePoint;
Console.WriteLine("How many duchies do you have? ");
int totalDuchyPoints = int.Parse(Console.ReadLine()) * duchyPoint;
Console.WriteLine("How many provinces do you have? ");
int totalProvincePoints = int.Parse(Console.ReadLine()) * provincePoint;

Console.WriteLine("You have a total of: ");

Console.WriteLine(totalEstatePoints + " points in estates");
Console.WriteLine(totalDuchyPoints +  " points in duchies");
Console.WriteLine(totalProvincePoints +  " points in provinces");

Console.WriteLine("Your kingdom is worth: " + (totalDuchyPoints + totalEstatePoints + totalProvincePoints));

