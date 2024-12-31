int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

double shipRent = 0.0;
switch (season)
{


    case "Spring":
        shipRent = 3000;

        if (fishermen <= 6)
        {
            shipRent = shipRent - (shipRent * 0.10);
        }
        else if (fishermen >= 7 && fishermen <= 11)
        {
            shipRent = shipRent - (shipRent * 0.15);
        }
        else if (fishermen >= 12)
        {
            shipRent = shipRent - (shipRent * 0.25);
        }
        break;

    case "Summer":
    case "Autumn":

        shipRent = 4200;

        if (fishermen <= 6)
        {
            shipRent = shipRent - (shipRent * 0.10);
        }
        else if (fishermen >= 7 && fishermen <= 11)
        {
            shipRent = shipRent - (shipRent * 0.15);
        }
        else if (fishermen >= 12)
        {
            shipRent = shipRent - (shipRent * 0.25);
        }
        break;

    case "Winter":
        shipRent = 2600;

        if (fishermen <= 6)
        {
            shipRent = shipRent - (shipRent * 0.10);
        }
        else if (fishermen >= 7 && fishermen <= 11)
        {
            shipRent = shipRent - (shipRent * 0.15);
        }
        else if (fishermen >= 12)
        {
            shipRent = shipRent - (shipRent * 0.25);
        }
        break;

}

if (fishermen % 2 == 0 && season != "Autumn")
{
    shipRent = shipRent - (shipRent * 0.05);
}

if (budget >= shipRent)
{
    Console.WriteLine($"Yes! You have {budget - shipRent:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {shipRent - budget:f2} leva.");
}