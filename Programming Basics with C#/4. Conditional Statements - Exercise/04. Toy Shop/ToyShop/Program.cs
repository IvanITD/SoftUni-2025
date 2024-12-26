//User Input
double tripPrice = double.Parse(Console.ReadLine());
int puzzlesAmount = int.Parse(Console.ReadLine());
int dollsAmount = int.Parse(Console.ReadLine());
int teddyBearsAmount = int.Parse(Console.ReadLine());
int minionsAmount = int.Parse(Console.ReadLine());
int trucksAmount = int.Parse(Console.ReadLine());

//Toy Prices
double puzzlePrice = puzzlesAmount * 2.60;
double dollPrice =  dollsAmount * 3.00;
double teddyBearPrice = teddyBearsAmount * 4.10;
double minionPrice = minionsAmount * 8.20;
double truckPrice = trucksAmount * 2.00;

//The total price of the toys
double totalToyPrice = puzzlePrice + dollPrice + teddyBearPrice + minionPrice + truckPrice;

//The amount of toys
double totalToyAmount = puzzlesAmount + dollsAmount + teddyBearsAmount + minionsAmount + trucksAmount;

//If the toys amount is more than or equal to 50, the store makes a 25% discount on the total price.
if (totalToyAmount >= 50)
{
    totalToyPrice = totalToyPrice - (totalToyPrice * 0.25);

    //The rent price is 10% of the discounted price.
    double rentPrice = totalToyPrice * 0.10;

    //Profit
    double remainingMoney = totalToyPrice - rentPrice;

    //Check if the profit is enough to go to the trip.
    if (remainingMoney >= tripPrice)
    {
        Console.WriteLine($"Yes! {remainingMoney - tripPrice:f2} lv left.");
    }
    else
    {
        Console.WriteLine($"Not enough money! {tripPrice - remainingMoney:f2} lv needed.");
    }

}
else
{
    //The rent price is 10% of the discounted price.
    double rentPrice = totalToyPrice * 0.10;

    //Profit
    double remainingMoney = totalToyPrice - rentPrice;

    //Check if the profit is enough to go to the trip.
    if (remainingMoney >= tripPrice)
    {
        Console.WriteLine($"Yes! {remainingMoney - tripPrice:f2} lv left.");
    }
    else
    {
        Console.WriteLine($"Not enough money! {tripPrice - remainingMoney:f2} lv needed.");
    }
}