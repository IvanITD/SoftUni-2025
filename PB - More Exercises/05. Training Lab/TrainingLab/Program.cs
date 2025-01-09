//User input
double w = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

//Turning meters to centimeters
double widthCm = w * 100;
double heightCm = h * 100;

// Now I need to remove the 100 cm for the corridor
heightCm = heightCm - 100;

// Amount of desks in a row (by width) and amount of rows (by height)
int desksPerRow = (int)heightCm / 70;
int rows = (int)widthCm / 120;

// Total amount of desks
int totalDesks = desksPerRow * rows;

// Removing three desks for the teacher's desk and the front door
totalDesks -= 3;

//Printing the result
 Console.WriteLine(totalDesks);