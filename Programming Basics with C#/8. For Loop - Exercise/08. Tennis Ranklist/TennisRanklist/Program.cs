// User Input
int tournaments = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());  // Store initial points
int points = initialPoints;  // Set points to initial value

// Created a variable to count the number of wins
int wins = 0;

// For every tournament we read a different line
for (int i = 0; i < tournaments; i++)
{
  // The stages are W, F, SF, QF
  string stage = Console.ReadLine();

  // We check the stage and add points
  if (stage == "W")
  {
    points += 2000;
    wins++;
  }
  else if (stage == "F")
  {
    points += 1200;
  }
  else if (stage == "SF")
  {
    points += 720;
  }
}

// We print the total points
Console.WriteLine($"Final points: {points}");

// We print the average points (only counting points earned in tournaments)
Console.WriteLine($"Average points: {(points - initialPoints) / tournaments}");

// We print the percentage of wins
Console.WriteLine($"{((double)wins / tournaments) * 100:F2}%");
