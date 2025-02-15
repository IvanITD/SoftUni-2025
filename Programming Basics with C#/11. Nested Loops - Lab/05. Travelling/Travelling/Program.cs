// User Input
string destination = Console.ReadLine();

// Creating a While loop to check the budget
while (destination != "End")
{
    // Reading the minimal budget for the current destination
    double minimalBudget = double.Parse(Console.ReadLine());
    // Creating a variable to store the saved money
    double savedMoney = 0;

    // Creating a While loop to check the saved money
    while (savedMoney < minimalBudget)
    {

        // Adding the current money to the saved money
        savedMoney += double.Parse(Console.ReadLine());
    }

    // Printing the destination to the Console
    Console.WriteLine($"Going to {destination}!");
    // Reading the next destination
    destination = Console.ReadLine();
}