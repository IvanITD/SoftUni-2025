// User Input
double change = double.Parse(Console.ReadLine());

// Creating a variable to round the change into cents
int cents = (int)(change * 100);

// Coins count variable for later use
int coinsCount = 0;

// While loop to calculate the number of coins needed
while (cents > 0)
{
    if (cents >= 200)
    {
        // Subtracting 200 from the cents
        cents -= 200;
    }
    else if (cents >= 100)

    {
        // Subtracting 100 from the cents
        cents -= 100;
    }
    else if (cents >= 50)

    {
        // Subtracting 50 from the cents
        cents -= 50;
    }
    else if (cents >= 20)

    {
        // Subtracting 20 from the cents
        cents -= 20;
    }
    else if (cents >= 10)

    {
        // Subtracting 10 from the cents
        cents -= 10;
    }
    else if (cents >= 5)

    {
        // Subtracting 5 from the cents
        cents -= 5;
    }
    else if (cents >= 2)

    {
        // Subtracting 2 from the cents
        cents -= 2;
    }
    else if (cents >= 1)

    {
        // Subtracting 1 from the cents
        cents -= 1;
    }

    // Adding 1 to the coins count for each coin used
    coinsCount++;

}

// Printing the number of coins needed
Console.WriteLine(coinsCount);