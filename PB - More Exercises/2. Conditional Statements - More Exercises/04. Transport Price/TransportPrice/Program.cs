int n = int.Parse(Console.ReadLine());
string time = Console.ReadLine();

// variable for the tariff
double tariff = 0.0;
double price = 0.0;

if (n >= 100) // If the kilometers are more than 100, the price will be 0.06 regardless of the time of day
{
    tariff = 0.06;
    price = n * tariff;

}
else if (n >= 20)
{
    tariff = 0.09;
    price = n * tariff;
}
else
{
    if (time == "day")
    {
        double dayTariff = 0.79;
        tariff = dayTariff;
        price = n * tariff + 0.70;
    }
    else if (time == "night")
    {
        double nightTariff = 0.90;
        tariff = nightTariff;
        price = n * tariff + 0.70;
    }
}

Console.WriteLine($"{price:F2}");