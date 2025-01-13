// User Input
int x = int.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
int workersAmount = int.Parse(Console.ReadLine());

// For one liter wine we need 2.5kg grapes
double grapesForOneLiterWine = 2.5;

// total grapes
double totalGrapes = x * y;

// Wine
double wine = (totalGrapes * 0.40) / grapesForOneLiterWine;

// Wine for 1 worker
double wineForOneWorker = (wine - z) / workersAmount;

// Check if we have enough wine
if (wine < z)
{
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - wine)} liters wine needed.");
}
else if (wine >= z)
{
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
    Console.WriteLine($"{Math.Ceiling(wine - z)} liters left -> {Math.Ceiling(wineForOneWorker)} liters per person.");
}