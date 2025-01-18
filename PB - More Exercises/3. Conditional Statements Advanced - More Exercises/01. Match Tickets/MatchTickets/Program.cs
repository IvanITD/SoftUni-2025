// User Inputs
double budget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int people = int.Parse(Console.ReadLine());

// ticket prices
double vipPrice = 499.99;
double normalPrice = 249.99;

// Variables for later use
double transportPrice = 0.0;
double ticketPrice = 0.0;

// Check how many people are going to the concert and calculate the transport price
if (people >= 1 && people <= 4) // 75% of the budget
{
    transportPrice = budget * 0.75;
    budget -= transportPrice;
}
else if (people >= 5 && people <= 9) // 60% of the budget
{
    transportPrice = budget * 0.60;
    budget -= transportPrice;
}
else if (people >= 10 && people <= 24) // 50% of the budget
{
    transportPrice = budget * 0.50;
    budget -= transportPrice;
}
else if (people >= 25 && people <= 49) // 40% of the budget
{
    transportPrice = budget * 0.40;
    budget -= transportPrice;
}
else if (people >= 50) // 25% of the budget
{
    transportPrice = budget * 0.25;
    budget -= transportPrice;
}


// Check what type of ticket the user wants to buy
if (category == "VIP")
{
    // Calculating the total VIP tickets price after multiplying by the people amount
    ticketPrice = vipPrice * people;
}
else if (category == "Normal")
{
    // Calculating the total normal tickets price after multiplying by the people amount
    ticketPrice = normalPrice * people;
}

// Check if the user has enough money to buy the tickets
if (budget >= ticketPrice)
{
    Console.WriteLine($"Yes! You have {budget - ticketPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {ticketPrice - budget:f2} leva.");
}