// User Input
int n = int.Parse(Console.ReadLine());

// Creating variables for the percentages, so that they can be used later
double p1 = 0;
double p2 = 0;
double p3 = 0;
double p4 = 0;
double p5 = 0;

// Creating a loop to go through all numbers
for (int i = 0; i < n; i++)
{
  // User inputs a number
  int num = int.Parse(Console.ReadLine());

  // Checking if the number is in the range and adding to the percentage
  if (num < 200)
  {
    // p1 is the percentage of numbers in the range 0-199
    p1++;
  }
  else if (num >= 200 && num <=399)
  {
    // p2 is the percentage of numbers in the range 200-399
    p2++;
  }
  else if (num >= 400 && num <=599)
  {
    // p3 is the percentage of numbers in the range 400-599
    p3++;
  }
  else if (num >= 600 && num <=799)
  {
    // p4 is the percentage of numbers in the range 600-799
    p4++;
  }
  else if (num >= 800)
  {
    // p5 is the percentage of numbers in the range 800-1000
    p5++;
  }
}

// Calculating the percentages
p1 = (p1 / n) * 100;
p2 = (p2 / n) * 100;
p3 = (p3 / n) * 100;
p4 = (p4 / n) * 100;
p5 = (p5 / n) * 100;

// Printing the output
Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");
Console.WriteLine($"{p4:f2}%");
Console.WriteLine($"{p5:f2}%");