double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
string place = "";
double discount = 0.0;
double totalPrice = 0.0;

if (budget <= 100) //if budget is less or equal to 100, he can go to Bulgaria
{
    destination = "Bulgaria";

    switch (season)
    {
        case "summer": //If the season is summer, he can go to camp
            place = "Camp";
            discount = 0.30;
            totalPrice = budget * discount;
            break;

        case "winter": //if the season is winter, he can go to hotel
            place = "Hotel";
            discount = 0.70;
            totalPrice = budget * discount;
            break;
    }
}
else if (budget <= 1000) //If the budget is less or equal to 1000, he can go across the Balkans
{
    destination = "Balkans";

    switch (season)
    {
        case "summer": //If the season is summer, he can go to camp
            place = "Camp";
            discount = 0.40;
            totalPrice = budget * discount;
            break;

        case "winter": //if the season is winter, he can go to hotel
            place = "Hotel";
            discount = 0.80;
            totalPrice = budget * discount;
            break;
    }
}
else if (budget > 1000) //If the budget is more than 1000, he can go to Europe
{
    destination = "Europe";
    //Whether the season is summer or winter, the option is hotel
    place = "Hotel";
    discount = 0.90;
    totalPrice = budget * discount;
}
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{place} - {totalPrice:f2}");
