//User Inputs
int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int veganMenu = int.Parse(Console.ReadLine());

//Price of each menu
double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double veganMenuPrice = 8.15;

//Summing of each menu separately
double chickenMenuTotal = chickenMenu * chickenMenuPrice;
double fishMenuTotal = fishMenu * fishMenuPrice;
double veganMenuTotal = veganMenu * veganMenuPrice;

//Combining the total price of all menus
double totalMenuPrice = chickenMenuTotal + fishMenuTotal + veganMenuTotal;

//Desert Price = 20% of the total price
double desertPrice = totalMenuPrice * 0.20;

//Delivery Price
double deliveryPrice = 2.50;

//Total Price
double totalPrice = totalMenuPrice + desertPrice + deliveryPrice;

//Total Price Output
Console.WriteLine(totalPrice);