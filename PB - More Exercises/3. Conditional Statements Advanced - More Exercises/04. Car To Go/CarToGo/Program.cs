// User Input
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

// variables for later use
string classType = "";
string carType = "";
double carPrice = 0.0;


// Check if budget is less than 100
if (budget <= 100)
{
    // If the budget is <= 100 then the class type is Eco
    classType = "Economy class";

    // Check what the season is
    if (season == "Summer")
    {
        // If the season is summer then the car type is Cabrio
        carType = "Cabrio";

        // The price is 35% from the budget
        carPrice = budget * 0.35;
    }
    else if (season == "Winter")
    {
        // If the season is winter then the car type is Jeep
        carType  = "Jeep";

        // The price is 65% from the budget
        carPrice = budget * 0.65;
    }
    
}
else if (budget > 100 && budget <= 500)
{
    // If the budget is > 100 and <= 500 then the class type is Compact
    classType = "Compact class";

    // Check what the season is
    if (season == "Summer")
    {
        // If the season is summer then the car type is Cabrio
        carType = "Cabrio";

        // The price is 45% from the budget
        carPrice = budget * 0.45;
    }
    else if (season == "Winter")
    {
        // If the season is winter then the car type is Jeep
        carType = "Jeep";

        // The price is 80% from the budget
        carPrice = budget * 0.80;
    }
}
else if (budget > 500)
{
    // If the budget is > 500 then the class type is Luxury
    classType = "Luxury class";

    if (season == "Summer" || season == "Winter")
    {
        // If the season is summer or winter then the car type is Jeep
        carType = "Jeep";

        // The price is 90% from the budget
        carPrice = budget * 0.90;
    }
}

Console.WriteLine($"{classType}");
Console.WriteLine($"{carType} - {carPrice:f2}");