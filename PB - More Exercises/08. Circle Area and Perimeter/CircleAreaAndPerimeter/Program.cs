double r = double.Parse(Console.ReadLine());

// Area of a circle
double areaOfCircle = r * r * Math.PI;

// Perimeter of a circle
double perimeterOfCircle = 2 * Math.PI * r;

// Print the results
Console.WriteLine($"{areaOfCircle:f2}");
Console.WriteLine($"{perimeterOfCircle:f2}");