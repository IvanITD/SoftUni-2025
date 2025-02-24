// User Input
int strokes = int.Parse(Console.ReadLine());

// Variables for later use
int strokeNum = 0;
double points = 0;
double percent = 0;
int counterZeroToNine = 0;
int counterTenToNineteen = 0;
int counterTwentyToTwentyNine = 0;
int counterThirtyToThirtyNine = 0;
int counterFortyToFifty = 0;
int counterInvalid = 0;
double percentZeroToNine = 0;
double percentTenToNineteen = 0;
double percentTwentyToTwentyNine = 0;
double percentThirtyToThirtyNine = 0;
double percentFortyToFifty = 0;
double percentInvalid = 0;

// Creating a for loop to iterate through the strokes
for (int i = 1; i <= strokes; i++)
{
  strokeNum = int.Parse(Console.ReadLine());

  // If the stroke is between 0 and 9
  if (strokeNum >= 0 && strokeNum <= 9)
  {
    // Calculating the points
    points += (double)strokeNum * 0.2;

    // Incrementing the counter for the interval
    counterZeroToNine++;
  }
  // If the stroke is between 10 and 19
  else if (strokeNum >= 10 && strokeNum <= 19)
  {
    // Calculating the points
    points += (double)strokeNum * 0.3;

    // Incrementing the counter for the interval
    counterTenToNineteen++;
  }
  // If the stroke is between 20 and 29
  else if (strokeNum >= 20 && strokeNum <= 29)
  {
    // Calculating the points
    points += (double)strokeNum * 0.4;

    // Incrementing the counter for the interval
    counterTwentyToTwentyNine++;
  }
  // If the stroke is between 30 and 39
  else if (strokeNum >= 30 && strokeNum <= 39)
  {
    // Calculating the points
    points += 50;

    // Incrementing the counter for the interval
    counterThirtyToThirtyNine++;
  }
  // If the stroke is between 40 and 50
  else if (strokeNum >= 40 && strokeNum <= 50)
  {
    // Calculating the points
    points += 100;

    // Incrementing the counter for the interval
    counterFortyToFifty++;
  }
  // If the stroke is greater than 50
  else if (strokeNum < 0 || strokeNum > 50)
  {
    // Calculating the points
    points /= 2;

    // Incrementing the counter for the invalid interval
    counterInvalid++;
  }
}

// Calculating the percentage
percentZeroToNine = (double)counterZeroToNine / strokes * 100;
percentTenToNineteen = (double)counterTenToNineteen / strokes * 100;
percentTwentyToTwentyNine = (double)counterTwentyToTwentyNine / strokes * 100;
percentThirtyToThirtyNine = (double)counterThirtyToThirtyNine / strokes * 100;
percentFortyToFifty = (double)counterFortyToFifty / strokes * 100;
percentInvalid = (double)counterInvalid / strokes * 100;

// Output
Console.WriteLine($"{points:f2}");
Console.WriteLine($"From 0 to 9: {percentZeroToNine:f2}%");
Console.WriteLine($"From 10 to 19: {percentTenToNineteen:f2}%");
Console.WriteLine($"From 20 to 29: {percentTwentyToTwentyNine:f2}%");
Console.WriteLine($"From 30 to 39: {percentThirtyToThirtyNine:f2}%");
Console.WriteLine($"From 40 to 50: {percentFortyToFifty:f2}%");
Console.WriteLine($"Invalid numbers: {percentInvalid:f2}%");