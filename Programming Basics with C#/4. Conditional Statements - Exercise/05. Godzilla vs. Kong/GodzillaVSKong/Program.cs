//User Inputs
double filmBudget = double.Parse(Console.ReadLine());
int statistsAmount = int.Parse(Console.ReadLine());
double clothPricePerStatist = double.Parse(Console.ReadLine());


//Prices and calculations
double decorPrice = filmBudget * 0.10;
double clothPrice = statistsAmount * clothPricePerStatist;

//Check if statists amount is bigger than 150 so that we can apply discount on the clothe price
if (statistsAmount >= 150)
{
    clothPrice = clothPrice - (clothPrice * 0.10); // 10% discount
    
    

    
}

//Total Price for clothes and decor
    double totalPrice = decorPrice + clothPrice;


//Logically check if we have enough money for the film
    if (totalPrice > filmBudget)
    {
        Console.WriteLine("Not enough money!");
        Console.WriteLine($"Wingard needs {totalPrice - filmBudget:f2} leva more.");
    }
    else
    {
        Console.WriteLine("Action!");
        Console.WriteLine($"Wingard starts filming with {filmBudget - totalPrice:f2} leva left.");
    }