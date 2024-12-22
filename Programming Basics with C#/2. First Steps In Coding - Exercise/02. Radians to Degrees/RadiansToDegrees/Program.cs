//User input
double radians = double.Parse(Console.ReadLine());

//Turning radians to degrees
double degrees = radians * 180 / Math.PI;

//Output
Console.WriteLine($"{degrees}");