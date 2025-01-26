// User input
int n = int.Parse(Console.ReadLine());

// Creating a variable named Sum for later use
int sum = 0;

// Creating a variable for Max Number
int maxNum = int.MinValue;

// Creating a for loop to cyrcle through the number n times
for (int i = 0; i < n; i++)
{
  // User inputs n times a number
  int num = int.Parse(Console.ReadLine());
  sum += num;

  // Checking to see if the number is bigger than the max number
  if (num > maxNum)
  {
    maxNum = num;
  }
}

// Subtracting the max number from the sum
int sumWithoutMaxNumber = sum - maxNum;

// Checking to see if the sum is equal to the max number
if (maxNum == sumWithoutMaxNumber)
{
  // Printing the result to the User
  Console.WriteLine("Yes");
  Console.WriteLine($"Sum = {maxNum}");
}
else
{
  // Printing the result to the User
  Console.WriteLine("No");
  Console.WriteLine($"Diff = {Math.Abs(maxNum - sumWithoutMaxNumber)}");
}