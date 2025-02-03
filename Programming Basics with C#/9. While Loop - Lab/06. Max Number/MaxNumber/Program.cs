// Variable to store the maximum number
int maxNumber = int.MinValue;

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
    if (number > maxNumber)
    {
        maxNumber = number;
    }
}

// Print the maximum number
Console.WriteLine(maxNumber);