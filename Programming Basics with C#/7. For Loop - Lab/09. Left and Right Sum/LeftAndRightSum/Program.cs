// User input
int n = int.Parse(Console.ReadLine());

// Create variables for left and right sum
int leftSum = 0;
int rightSum = 0;

// Create a for loop for the left sum
for (int i = 1; i <= n; i++)
{
  // The user inputs the number-s for the left sum
  leftSum += int.Parse(Console.ReadLine());
}

// Create a for loop for the right sum
for (int i = 1; i <= n; i++)
{
  // The user inputs the number-s for the right sum
  rightSum += int.Parse(Console.ReadLine());
}

// Check if the left sum is equal to the right sum
if (leftSum == rightSum)
{
  Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
  Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
}