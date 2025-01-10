double vegetablePrice = double.Parse(Console.ReadLine());
double fruitPrice = double.Parse(Console.ReadLine());
int vegetableKg = int.Parse(Console.ReadLine());
int fruitKg = int.Parse(Console.ReadLine());

double vegetableTotal = vegetableKg * vegetablePrice;
double fruitTotal = fruitKg * fruitPrice;

double total = (vegetableTotal + fruitTotal) / 1.94;

Console.WriteLine($"{total:f2}");