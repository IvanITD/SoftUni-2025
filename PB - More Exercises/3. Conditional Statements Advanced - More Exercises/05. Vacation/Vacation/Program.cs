// User Input
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

// Variables for later use
string stayPlace = "";
string location = "";
double price = 0.0;

// Check if the budget is less than 1000 leva
if (budget <= 1000)
{
  // The place to stay will be a Camp
  stayPlace = "Camp";

  // Check whether the season is Summer or Winter
  if (season == "Summer")
  {
    // The location will be Alaska
    location = "Alaska";

    // The season is Summer, so the price will be 65% of the budget
    price = budget * 0.65;
  }
  else if (season == "Winter")
  {
    // The location will be Morroco
    location = "Morocco";

    // The season is Winter, so the price will be 45% of the budget
    price = budget * 0.45;
  }

}
else if (budget > 1000 && budget <= 3000)
{
  // The place to stay will be a Hut
  stayPlace = "Hut";

  // Check whether the season is Summer or Winter
  if (season == "Summer")
  {
    // The location will be Alaska
    location = "Alaska";

    // The season is Summer, so the price will be 80% of the budget
    price = budget * 0.80;
  }
  else if (season == "Winter")
  {
    // The location will be Morroco
    location = "Morocco";

    // The season is Winter, so the price will be 60% of the budget
    price = budget * 0.60;
  }
}
else if (budget > 3000)
{
  // The place to stay will be a Hotel
  stayPlace = "Hotel";

  // Check whether the season is Summer or Winter
  if (season == "Summer")
  {
    // The location will be Alaska
    location = "Alaska";

    // The season is Summer, so the price will be 90% of the budget
    price = budget * 0.90;
  }
  else if (season == "Winter")
  {
    // The location will be Morroco
    location = "Morocco";

    // The season is Winter, so the price will be 90% of the budget
    price = budget * 0.90;
  }
}

// Print the output
Console.WriteLine($"{location} - {stayPlace} - {price:f2}");