int n = int.Parse(Console.ReadLine());

for (int number = 1111; number <= 9999; number++)
{
    bool isSpecial = true;

    int currentNumber = number;

    while (currentNumber > 0)
    {
        int digit = currentNumber % 10; // Get the last digit

        if (digit == 0 || n % digit != 0)
        {
            isSpecial = false;
            break; // Exit loop early if any digit doesn't divide N
        }

        currentNumber /= 10; // Remove the last digit
    }

    if (isSpecial)
    {
        Console.Write(number + " ");
    }
}
