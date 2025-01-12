//User Inputs
int v = int.Parse(Console.ReadLine());
int p1 = int.Parse(Console.ReadLine());
int p2 = int.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

//For curtain amount of hours
double p1H = p1 * h;
double p2H = p2 * h;

//Total pipe hours
double totalPipeLiters = p1H + p2H;

//Total pipe percentage
double totalPoolPercentage = (totalPipeLiters / v) * 100;

//Percentage for each pipe
double p1Percentage = (p1H / totalPipeLiters) * 100;
double p2Percentage = (p2H / totalPipeLiters) * 100;

//Overflow
if (totalPipeLiters > v)
{
    Console.WriteLine($"For {h} hours the pool overflows with {totalPipeLiters - v} liters.");
}
else
{
    Console.WriteLine($"The pool is {totalPoolPercentage:f2}% full Pipe 1: {p1Percentage:f2}%. Pipe 2: {p2Percentage:f2}%.");
}