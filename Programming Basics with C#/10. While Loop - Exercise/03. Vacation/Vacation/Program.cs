// User Input
double neededMoney = double.Parse(Console.ReadLine());
double availableMoney = double.Parse(Console.ReadLine());

int daysCount = 0;
int spendCount = 0;

while (availableMoney < neededMoney && spendCount < 5)
{
    string action = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());

    daysCount++;

    if (action == "spend")
    {
        availableMoney -= amount;
        if (availableMoney < 0)
        {
            availableMoney = 0;
        }
        spendCount++;
    }
    else if (action == "save")
    {
        availableMoney += amount;
        spendCount = 0;
    }
}

if (spendCount == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(daysCount);
}
else
{
    Console.WriteLine($"You saved the money for {daysCount} days.");
}
