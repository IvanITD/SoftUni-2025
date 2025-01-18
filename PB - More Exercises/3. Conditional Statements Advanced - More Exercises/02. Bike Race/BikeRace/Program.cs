// User Inputs
int juniors = int.Parse(Console.ReadLine());
int seniors = int.Parse(Console.ReadLine());
string route = Console.ReadLine();

// Keep the junior's and senior's prices in variables
double juniorPrice = 0.0;
double seniorPrice = 0.0;

// Calculate the total number of riders
int totalRiders = juniors + seniors;

// Check the route
switch (route)
{
    case "trail":
    juniorPrice = 5.50;
    seniorPrice = 7.00;
    break;

    case "cross-country":
    juniorPrice = 8.00;
    seniorPrice = 9.50;

    if (totalRiders >= 50)
    {
        juniorPrice -= juniorPrice * 0.25;
        seniorPrice -= seniorPrice * 0.25;
    }
    break;

    case "downhill":
    juniorPrice = 12.25;
    seniorPrice = 13.75;
    break;

    case "road":
    juniorPrice = 20.00;
    seniorPrice = 21.50;
    break;

}

// Calculate the price for each type of rider
double juniorTotalPrice = juniors * juniorPrice;
double seniorTotalPrice = seniors * seniorPrice;

// Calculate the total price
double total = juniorTotalPrice + seniorTotalPrice;

// The expenses are 5% of the total price
double expenses = total * 0.05;

Console.WriteLine($"{total - expenses:f2}");

