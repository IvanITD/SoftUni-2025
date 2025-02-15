// User Input
string destination = Console.ReadLine();
int minimalBudget = int.Parse(Console.ReadLine());

// Creating a While loop to check the budget
while (true)
{
    // Creating a variable to store the saved money
    int savedMoney = 0;

    // Creating a While loop to check the saved money
    while (savedMoney < minimalBudget)
    {
        // Reading the current money that Ani has saved
        int currentMoney = int.Parse(Console.ReadLine());

        // Adding the current money to the saved money
        savedMoney += currentMoney;
    }

    // Printing the destination to the Console
    Console.WriteLine($"Going to {destination}!");
    // Reading the next destination
    destination = Console.ReadLine();

    // Checking If the destination is "End" break the loop
    if (destination == "End")
    {
        break;
    }
    
    // If the destination is not End, read the minimal budget for the next destination
    minimalBudget = int.Parse(Console.ReadLine());
}