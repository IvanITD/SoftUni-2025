string fuelType = Console.ReadLine();
double litresFuel = double.Parse(Console.ReadLine());

if (fuelType == "Diesel")
{
    if (litresFuel >= 25)
    {
        Console.WriteLine($"You have enough {fuelType.ToLower()}.");
    }
    else if (litresFuel < 25)
    {
        Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
    }
}
else if (fuelType == "Gasoline")
{
    if (litresFuel >= 25)
    {
        Console.WriteLine($"You have enough {fuelType.ToLower()}.");
    }
    else if (litresFuel < 25)
    {
        Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
    }
}
else if (fuelType == "Gas")
{
    if (litresFuel >= 25)
    {
        Console.WriteLine($"You have enough {fuelType.ToLower()}.");
    }
    else if (litresFuel < 25)
    {
        Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
    }
}
else
{
    Console.WriteLine("Invalid fuel!");
}