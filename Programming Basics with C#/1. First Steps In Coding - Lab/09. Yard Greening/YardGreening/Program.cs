//User input
double greeningArea = double.Parse(Console.ReadLine());

//Greening Price per square meter
double greeningPrice = 7.61;

//The Total Price
double price = greeningArea * greeningPrice;

//The discount
double discount = price * 0.18;

//Total price after discount
double totalPrice = price - discount;

//The output
Console.WriteLine($"The final price is: {totalPrice} lv.");
Console.WriteLine($"The discount is: {discount}");