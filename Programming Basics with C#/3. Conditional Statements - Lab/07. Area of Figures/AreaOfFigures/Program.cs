string viewFigure = Console.ReadLine();

if (viewFigure == "square")
{
    double squareLength = double.Parse(Console.ReadLine());
    double squareArea = squareLength * squareLength;

    Console.WriteLine($"{squareArea:f3}");
}
else if (viewFigure == "rectangle")
{
    double rectangleSide1 = double.Parse(Console.ReadLine());
    double rectangleSide2 = double.Parse(Console.ReadLine());

    double rectangleArea = rectangleSide1 * rectangleSide2;

    Console.WriteLine($"{rectangleArea:f3}");

}
else if (viewFigure == "circle")
{
    double circleRadius = double.Parse(Console.ReadLine());
    double circleArea = circleRadius * circleRadius * Math.PI;

    Console.WriteLine($"{circleArea:f3}");
}
else if (viewFigure == "triangle")
{
    double triangleLength = double.Parse(Console.ReadLine());
    double triangleHeight = double.Parse(Console.ReadLine());

    double triangleArea = (triangleLength * triangleHeight) / 2;

    Console.WriteLine($"{triangleArea:f3}");
}