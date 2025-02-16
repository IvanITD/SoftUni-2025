// User Input
int peopleCount = int.Parse(Console.ReadLine());
int nightsCount = int.Parse(Console.ReadLine());
int transportCardsCount = int.Parse(Console.ReadLine());
int museumTicketsCount = int.Parse(Console.ReadLine());

// Pricing
double nightPrice = 20.00;
double transportCardPrice = 1.60;
double museumTicketPrice = 6.00;

// Calculating the price per each count
double nightTotal = nightsCount * nightPrice;
double transportCardTotal = transportCardsCount * transportCardPrice;
double museumTicketTotal = museumTicketsCount * museumTicketPrice;

// Calculating the total price for one person
double totalPrice = nightTotal + transportCardTotal + museumTicketTotal;

// Calculating the total price for a group
double groupPrice = totalPrice * peopleCount;

// Adding unpredicted expenses
groupPrice += groupPrice * 0.25;

// Printing the result to the Console
Console.WriteLine($"{groupPrice:F2}");