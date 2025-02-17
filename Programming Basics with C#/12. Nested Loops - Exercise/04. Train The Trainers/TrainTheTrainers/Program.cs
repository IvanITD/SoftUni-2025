// User input
int juryCount = int.Parse(Console.ReadLine());

// Creating variables for later use
double totalScore = 0.0;
int presentationCount = 0;

// Creating a string variable so that the User can input the named of the presentation
string presentationName = Console.ReadLine();

// Creating a while loop to circle through the presentations
while (presentationName != "Finish")
{
  // Creating a double variable to count the presentationTotal
  double presentationTotal = 0;

  // Receive the scores for the presentations
  for (int i = 0; i < juryCount; i++)
  {
    // User inputs the score
    double score = double.Parse(Console.ReadLine());

    // Adding the score to the total presentation
    presentationTotal += score;
  }

  // Calculate and print the average for this presentation
  double presentationAverage = presentationTotal / juryCount;
  Console.WriteLine($"{presentationName} - {presentationAverage:F2}.");

  // Updating the total score
  totalScore += presentationAverage;
  presentationCount++;

  // Receiving the next presentation name from the User
  presentationName = Console.ReadLine();
}

// Calculating the final assessment
double finalAverage = totalScore / presentationCount;

// Printing the result to the Console.
Console.WriteLine($"Student's final assessment is {finalAverage:F2}.");