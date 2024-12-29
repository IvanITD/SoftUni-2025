string projectionType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

double projectionPrice = 0.0;
double totalPrice = 0.0;

switch (projectionType)
{
    case "Premiere":
    projectionPrice = 12.00;
    totalPrice = rows * columns * projectionPrice;
    break;

    case "Normal":
    projectionPrice = 7.50;
    totalPrice = rows * columns * projectionPrice;
    break;

    case "Discount":
    projectionPrice = 5.00;
    totalPrice = rows * columns * projectionPrice;
    break;

}

Console.WriteLine($"{totalPrice:f2} leva");