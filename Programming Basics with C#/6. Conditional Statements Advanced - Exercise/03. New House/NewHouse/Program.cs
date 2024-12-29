string flowerType = Console.ReadLine();
int flowerAmount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double flowerPrice = 0.0;

switch (flowerType)
{
    case "Roses":
        flowerPrice = flowerAmount * 5.0;

        if (flowerAmount > 80)
        {
            flowerPrice = flowerPrice - (flowerPrice * 0.10);
        }
        break;

    case "Dahlias":

        flowerPrice = flowerAmount * 3.80;

        if (flowerAmount > 90)
        {
            flowerPrice = flowerPrice - (flowerPrice * 0.15);
        }
        break;

    case "Tulips":

        flowerPrice = flowerAmount * 2.80;

        if (flowerAmount > 80)
        {
            flowerPrice = flowerPrice - (flowerPrice * 0.15);
        }
        break;

    case "Narcissus":

        flowerPrice = flowerAmount * 3.00;

        if (flowerAmount < 120)
        {
            flowerPrice = flowerPrice + (flowerPrice * 0.15);
        }
        break;

    case "Gladiolus":

        flowerPrice = flowerAmount * 2.50;

        if (flowerAmount < 80)
        {
            flowerPrice = flowerPrice + (flowerPrice * 0.20);
        }
        break;
}

if (budget >= flowerPrice)
{
    Console.WriteLine($"Hey, you have a great garden with {flowerAmount} {flowerType} and {budget - flowerPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {flowerPrice - budget:f2} leva more.");
}