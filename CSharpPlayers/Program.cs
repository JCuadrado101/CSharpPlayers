// Challenge: The Replicator of D'To

int[] original = new int[5];
int[] newArray = new int[5];
int total = 0;
float average = 0.0f;

Console.WriteLine("Enter 5 numbers for a new array");

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("New Array: [{0}]", string.Join(", ", newArray));
Console.WriteLine(" Original Array:  [{0}]", string.Join(", ", original));

for (int i = 0; i < original.Length; i++)
{
    original[i] = newArray[i];
}

Console.WriteLine(" Original Array: [{0}]", string.Join(", ", original));


// The Laws of Freach

foreach (int item in original)
{
    total += item;
}

Console.WriteLine("total: " + total);
Console.WriteLine("Average: " + total/original.Length);