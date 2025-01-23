// User Input
double heritage = double.Parse(Console.ReadLine());
int year = int.Parse(Console.ReadLine());

// Checking if the year is even
for (int i = 1800; i <= year; i++)
{
    if (i % 2 == 0)
    {
        heritage -= 12000;
    }
    else
    {
        heritage -= 12000 + 50 * (i - 1800 + 18);
    }
}

// Output
if (heritage >= 0)
{
  Console.WriteLine($"Yes! He will live a carefree life and will have {heritage:F2} dollars left.");
}
else
{
  Console.WriteLine($"He will need {Math.Abs(heritage):F2} dollars to survive.");
}