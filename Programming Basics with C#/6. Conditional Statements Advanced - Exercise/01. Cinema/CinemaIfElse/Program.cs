string projectionType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

double projectionPrice = 0.0;
double totalPrice = 0.0;

if (projectionType == "Premiere")
{
    projectionPrice = 12.00;
    totalPrice = rows * columns * projectionPrice;
}
else if (projectionType == "Normal")
{
    projectionPrice = 7.50;
    totalPrice = rows * columns * projectionPrice;
}
else if (projectionType == "Discount")
{
    projectionPrice = 5.00;
    totalPrice = rows * columns * projectionPrice;
}

Console.WriteLine($"{totalPrice:f2} leva");