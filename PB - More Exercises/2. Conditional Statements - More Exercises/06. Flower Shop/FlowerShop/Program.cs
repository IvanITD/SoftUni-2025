// User Inputs
int magnolias = int.Parse(Console.ReadLine());
int hyacinths = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int cacti = int.Parse(Console.ReadLine());
double giftPrice = double.Parse(Console.ReadLine());

// Flower Prices
double magnoliasPrice = 3.25;
double hyacinthsPrice = 4.00;
double rosesPrice = 3.50;
double cactiPrice = 8.00;

// 5% tax
double tax = 0.05;

// Each flower price multiplied by the quantity
double magnoliasTotal = magnolias * magnoliasPrice;
double hyacinthsTotal = hyacinths * hyacinthsPrice;
double rosesTotal = roses * rosesPrice;
double cactiTotal = cacti * cactiPrice;

// Total Flower Price
double totalFlowerPrice = magnoliasTotal + hyacinthsTotal + rosesTotal + cactiTotal;

// Total Price after tax
double taxedPrice = totalFlowerPrice - (totalFlowerPrice * tax);



// Checking if the money is enough
if (taxedPrice >= giftPrice)
{
    // Calculating to check if there's enough money
    double moneyLeft = taxedPrice - giftPrice;

    // Printing the output
    Console.WriteLine($"She is left with {Math.Floor(moneyLeft)} leva.");
}
else
{
    // Calculating to check if there's enough money
    double moneyNeeded = giftPrice - taxedPrice;

    // Printing the output
    Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyNeeded)} leva.");
}