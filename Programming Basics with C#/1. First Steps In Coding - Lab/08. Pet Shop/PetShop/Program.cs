int dogFoodAmount = int.Parse(Console.ReadLine());
int catFoodAmount = int.Parse(Console.ReadLine());

//Food Price
double dogFoodPrice = 2.50;
int catFoodPrice = 4;

//Dog and Cat Food Total
double dogFoodTotal = dogFoodAmount * dogFoodPrice;
int catFoodTotal = catFoodAmount * catFoodPrice;

//Final Price
double finalPrice = dogFoodTotal + catFoodTotal;

//The output
Console.WriteLine($"{finalPrice} lv.");