// User Input
int chrysanthemums = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int tulips = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
char holiday = char.Parse(Console.ReadLine());

// Variables for the flower prices
double chrysanthemumsPrice = 0.0;
double rosesPrice = 0.0;
double tulipsPrice = 0.0;

// Added variables for the discount from each flower bouquet
double bouquetDiscount = 0.0;

// Check what the season is, in order to determine the price for each flower
if (season == "Spring" || season == "Summer")
{
        chrysanthemumsPrice = 2.00;
        rosesPrice = 4.10;
        tulipsPrice = 2.50;

}
else if (season == "Autumn" || season == "Winter")
{
        chrysanthemumsPrice = 3.75;
        rosesPrice = 4.50;
        tulipsPrice = 4.15;
}

// Calculate the total price for each flower type
double chrysanthemumsTotal = chrysanthemums * chrysanthemumsPrice;
double rosesTotal = roses * rosesPrice;
double tulipsTotal = tulips * tulipsPrice;

// Check the total Price for all flowers
double totalPrice = chrysanthemumsTotal + rosesTotal + tulipsTotal;

// Check if it's a holiday
if (holiday == 'Y')
{
    totalPrice += totalPrice * 0.15;
}
else if (holiday == 'N')
{
    totalPrice += 0;
}

// Check the total amount of all flowers
double totalFlowers = chrysanthemums + roses + tulips;

if (tulips > 7 && season == "Spring")
{
    bouquetDiscount = 0.05;
    totalPrice -= totalPrice * bouquetDiscount;
}
else if (roses >= 10 && season == "Winter")
{
    bouquetDiscount = 0.10;
    totalPrice -= totalPrice * bouquetDiscount;
}

// Check if the total amount of all flowers is more than 20
if (totalFlowers > 20)
{
    bouquetDiscount = 0.20;
    totalPrice -= totalPrice * bouquetDiscount;
}


// Add 2 lv. for the arrangement
totalPrice += 2;

// Print the total price and format it to 2 digits after the decimal point
Console.WriteLine($"{totalPrice:f2}");