﻿// User Input
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());
double y  = double.Parse(Console.ReadLine());

// The dot is on the left or right side of the rectangle
if ((x == x1 || x == x2) && (y >= y1 && y <= y2))
{
  Console.WriteLine("Border");
}
// The dot is on the top or bottom side of the rectangle
else if ((y == y1 || y == y2) && (x >= x1 && x <= x2))
{
  Console.WriteLine("Border");
}
else
{
  Console.WriteLine("Inside / Outside");
}