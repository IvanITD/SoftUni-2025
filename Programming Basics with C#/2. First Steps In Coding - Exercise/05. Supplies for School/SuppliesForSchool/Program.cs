//User inputs
int penAmount = int.Parse(Console.ReadLine());
int markerAmount = int.Parse(Console.ReadLine());
int detergentLiters = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

//Price for each product
double penPrice = 5.80;
double markerPrice = 7.20;
double detergentPrice = 1.20;

//Calculations
double penTotalPrice = penAmount * penPrice;
double markerTotalPrice = markerAmount * markerPrice;
double detergentTotalPrice = detergentLiters * detergentPrice;

//The total price
double totalPrice = penTotalPrice + markerTotalPrice + detergentTotalPrice;

//Discount
double discount = totalPrice * discountPercentage / 100;

//Price with the discount
double discountedPrice = totalPrice - discount;

//The output
Console.WriteLine($"{discountedPrice}");