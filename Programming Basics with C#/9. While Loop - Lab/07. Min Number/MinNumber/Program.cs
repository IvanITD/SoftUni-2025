// Variable to store the minimum number
int minNumber = int.MaxValue;

// While loop to read numbers until "Stop" is
while (true)
{
    // User Input
    string input = Console.ReadLine();

    // If the input is "Stop", break the loop
    if (input == "Stop")
    {
        break;
    }

    // Convert the input to an integer
    int number = int.Parse(input);

    // If the number is greater than the current maximum number, update the maximum number
    if (number < minNumber)
    {
        minNumber = number;
    }
}

// Print the minimum number
Console.WriteLine(minNumber);