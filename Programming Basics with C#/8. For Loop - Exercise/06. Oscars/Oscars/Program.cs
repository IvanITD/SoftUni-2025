// User input
string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

// Loop for each category
for (int i = 0; i < n; i++)
{
    string evaluator = Console.ReadLine();
    double points = double.Parse(Console.ReadLine());

    // Calculate points
    academyPoints += evaluator.Length * points / 2;

    // Check if actor has enough points
    if (academyPoints > 1250.5)
    {
        break;
    }
}

// In order to print the right result, we need to check if the actor has enough points
if (academyPoints > 1250.5)
{
  // Print the result
    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
}
else
{
  // Print the result
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - academyPoints:f1} more!");
}