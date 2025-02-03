// User input
int n = int.Parse(Console.ReadLine());

// Create a variable to store the current number
int currentNumber = 1;

// While loop
while (currentNumber <= n)
{
    // Print the current number
    Console.WriteLine(currentNumber);

    // Increment the current number
    currentNumber = currentNumber * 2 + 1;
}