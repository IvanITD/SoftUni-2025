// User Input
string season = Console.ReadLine();
double kmPerMonth = double.Parse(Console.ReadLine());

// Variables for later use
double price = 0.0;

// Check if the kilometers per month are less than 5000
if (kmPerMonth <= 5000)
{
  // Check whether the season is Spring, Autumn, Summer or Winter
  if (season == "Spring" || season == "Autumn")
  {
    price = 0.75;
  }
  else if (season == "Summer")
  {
    price = 0.90;
  }
  else if (season == "Winter")
  {
    price = 1.05;
  }

}
else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
{
  if (season == "Spring" || season == "Autumn")
  {
    price = 0.95;
  }
  else if (season == "Summer")
  {
    price = 1.10;
  }
  else if (season == "Winter")
  {
    price = 1.25;
  }
}
else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
{
  if (season == "Spring" || season == "Autumn" || season == "Winter" || season == "Summer")
  {
    price = 1.45;
  }
}

// No to calculate the kilometers per month with the price per kilometers
double totalPrice = kmPerMonth * price;

// Calculate the total price after 4 months of work.
totalPrice *= 4;

// Calculate the total price after taxes
totalPrice -= totalPrice * 0.10;

// Print the result
Console.WriteLine($"{totalPrice:f2}");