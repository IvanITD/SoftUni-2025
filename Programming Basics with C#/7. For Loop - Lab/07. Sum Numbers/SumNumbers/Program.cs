int n = int.Parse(Console.ReadLine());

double total = 0;

for (int i = 0; i < n; i++)
{
    double number = double.Parse(Console.ReadLine());
    total += number;
}
Console.WriteLine(total);