// User Input
string season = Console.ReadLine();
string groupType = Console.ReadLine();
int numberOfStudents = int.Parse(Console.ReadLine());
int numberOfNights = int.Parse(Console.ReadLine());

// Variables for later use
double price = 0.0;
string sportType = "";
double totalPrice = 0.0;

// Check whether the group type is of boys, girls or mixed
switch (groupType)
{
  case "boys":
   // Check whether the season is Winter, Spring or Summer
  switch (season)
  {
    case "Winter":
    price = 9.60;
    sportType = "Judo";
    break;

    case "Spring":
    price = 7.20;
    sportType = "Tennis";
    break;

    case "Summer":
    price = 15.00;
    sportType = "Football";
    break;
  }
  break;

  case "girls":
  // Check whether the season is Winter, Spring or Summer
  switch (season)
  {
    case "Winter":
    price = 9.60;
    sportType = "Gymnastics";
    break;

    case "Spring":
    price = 7.20;
    sportType = "Athletics";
    break;

    case "Summer":
    price = 15.00;
    sportType = "Volleyball";
    break;
  }
  break;

  case "mixed":
  // Check whether the season is Winter, Spring or Summer
  switch (season)
  {
    case "Winter":
    price = 10.00;
    sportType = "Ski";
    break;

    case "Spring":
    price = 9.50;
    sportType = "Cycling";
    break;

    case "Summer":
    price = 20.00;
    sportType = "Swimming";
    break;
  }
  break;
}

// Sum the price with the number of students and nights
double sum = price * numberOfStudents * numberOfNights;

// Calculate whether the number of students is more than 50, 20-50 or less than 20
if (numberOfStudents >= 50)
{
  totalPrice = sum - (sum * 0.50);
}
else if (numberOfStudents >= 20 && numberOfStudents < 50)
{
  totalPrice = sum - (sum * 0.15);
}
else if (numberOfStudents >= 10 && numberOfStudents < 20)
{
  totalPrice = sum - (sum * 0.05);
}
else
{
  totalPrice = sum;
}

// Print the result
Console.WriteLine($"{sportType} {totalPrice:f2} lv.");