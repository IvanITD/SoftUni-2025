﻿int degrees = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

string outfit = "";
string shoes = "";

switch (dayTime)
{
    case "Morning":
        if (degrees >= 10 && degrees <= 18)
        {
            outfit = "Sweatshirt";
            shoes = "Sneakers";
        }
        else if (degrees > 18 && degrees <= 24)
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else if (degrees >= 25)
        {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        break;

    case "Afternoon":
        if (degrees >= 10 && degrees <= 18)
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else if (degrees > 18 && degrees <= 24)
        {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        else if (degrees >=25)
        {
            outfit = "Swim Suit";
            shoes = "Barefoot";
        }
        break;

    case "Evening":
        outfit = "Shirt";
        shoes = "Moccasins";
        break;
}

Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");