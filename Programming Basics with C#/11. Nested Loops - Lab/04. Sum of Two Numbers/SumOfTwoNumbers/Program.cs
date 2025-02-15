// User Input
int intervalStart = int.Parse(Console.ReadLine());
int intervalEnd = int.Parse(Console.ReadLine());
int magicalNumber = int.Parse(Console.ReadLine());

// Creating variables for later use
int combinations = 0;
bool isFound = false;

// Creating nested loops to check each number combination
for (int i = intervalStart; i <= intervalEnd; i++)
{
    for (int j = intervalStart; j <= intervalEnd; j++)
    {
        combinations++;
        
        if (i + j == magicalNumber)
        {
            Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicalNumber})");
            isFound = true;
            return;
        }
    }
}

// If no combination is found
if (!isFound)
{
    Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
}