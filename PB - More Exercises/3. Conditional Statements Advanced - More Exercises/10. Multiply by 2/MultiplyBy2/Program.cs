// Variable for later use
double result = 0.0;

while (true)
{
  // Read input
    double input = double.Parse(Console.ReadLine());

    // Check if input is negative
    if (input < 0)
    {
        Console.WriteLine("Negative number!");
        break;
    }
    else
    {
        // Multiply input by 2
        result = input * 2;
        Console.WriteLine($"Result: {result:f2}");
    }
}