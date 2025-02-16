// Creating variables holding the starting height, Everest height and the day count
int startingHeight = 5364;
int EverestHeight = 8848;
int days = 1; // Start from day 1

// Creating a while loop to loop through the days
while (true)
{
  // User Input
  string rest = Console.ReadLine();
  
  // Checking to see if he ended the climbing
  if (rest == "END")
  {
    // Printing to the console that he failed
    Console.WriteLine("Failed!");
    Console.WriteLine(startingHeight);
    break;
  }

  // User Input
  int climbedMeters = int.Parse(Console.ReadLine());

  // Checking to see if he decided to rest
  if (rest == "Yes")
  {
    days++; // Plus 1 to the day count
  }

  // Checking to see if the days counted more than 5
  if (days > 5)
  {
    // Printing to the Console that he failed, because it took him more than 5 days
    Console.WriteLine("Failed!");
    Console.WriteLine(startingHeight);
    break;
  }

  // Adding the climbed meters to the starting height
  startingHeight += climbedMeters;

  // Checking to see if the starting height is equal or more than the Everest height
  if (startingHeight >= EverestHeight)
  {
    // Printing to the console that he achieved climbing Everest
    Console.WriteLine($"Goal reached for {days} days!");
    break;
  }
}