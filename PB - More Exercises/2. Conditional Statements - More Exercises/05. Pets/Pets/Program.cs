// User Input
int days = int.Parse(Console.ReadLine());
int foodInKG = int.Parse(Console.ReadLine());
double foodForDogKG = double.Parse(Console.ReadLine());
double foodForCatKG = double.Parse(Console.ReadLine());
double foodForTurtleGM = double.Parse(Console.ReadLine());

// Calculating the needed dog food
double neededFoodForDogKG = days * foodForDogKG;

// Calculating the needed cat food
double neededFoodForCatKG = days * foodForCatKG;

// Calculating the needed turtle food
double neededFoodForTurtleKG = (days * foodForTurtleGM) / 1000;

// Calculating the total needed food
double totalFood = neededFoodForDogKG + neededFoodForCatKG + neededFoodForTurtleKG;

// Checking if the food is enough
if (totalFood <= foodInKG)
{
    // Calculating the remaining food
    double remainingFood = Math.Floor(foodInKG - totalFood);
    
    // Printing the output
    Console.WriteLine($"{remainingFood} kilos of food left.");
}
else
{    
    // Calculating the needed missing food
    double missingFood = Math.Ceiling(totalFood - foodInKG);

    // Printing the output
    Console.WriteLine($"{missingFood} more kilos of food are needed.");
}