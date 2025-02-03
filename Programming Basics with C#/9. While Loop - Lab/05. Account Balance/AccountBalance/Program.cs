// Variable to store the total balance
double totalBalance = 0;

// While loop
while (true)
{
    // User Input
    string input = Console.ReadLine();

    // If the input is "NoMoreMoney", break the loop
    if (input == "NoMoreMoney")
    {
        break;
    }

    // Convert the input to a double
    double amount = double.Parse(input);

    // If the amount is less than 0, print "Invalid operation!" and break the loop
    if (amount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    // Add the amount to the total balance
    totalBalance += amount;

    // Print the amount
    Console.WriteLine($"Increase: {amount:F2}");
}

// Print the total balance
Console.WriteLine($"Total: {totalBalance:F2}");