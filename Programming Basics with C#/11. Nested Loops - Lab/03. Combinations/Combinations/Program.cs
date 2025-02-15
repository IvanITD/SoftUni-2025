// User Input
int n = int.Parse(Console.ReadLine());

// Creating a counter for the combinations
int combinationsCount = 0;

// Creating a for loop that will iterate through all possible combinations of numbers from 0 to x1, and from 0 to x2, and from 0 to x3.
for (int x1 = 0; x1 <= n; x1++)
{
    for (int x2 = 0; x2 <= n; x2++)
    {
        for (int x3 = 0; x3 <= n; x3++)
        {
            if (x1 + x2 + x3 == n)
            {
                combinationsCount++;
            }
        }
    }
}

// Printing the number of combinationsCount
Console.WriteLine(combinationsCount);