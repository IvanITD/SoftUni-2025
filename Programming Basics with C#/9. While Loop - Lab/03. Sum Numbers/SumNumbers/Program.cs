// User input
int number = int.Parse(Console.ReadLine());

// Variable to store the sum
int sum = 0;

// While loop
while (true)
{
    // User input
    int input = int.Parse(Console.ReadLine());

    // Sum the input
    sum += input;

    // Check if the sum is greater than or equal to the number
    if (sum >= number)
    {
        // Print the sum
        Console.WriteLine(sum);
        break;
    }
}