// User input
int n = int.Parse(Console.ReadLine());

// Create variables to store the even and odd sums
int evenSum = 0;
int oddSum = 0;

// Loop through the number from 1 to number
for (int i = 1; i <= n; i++)
{
  // Check if the current number is even or odd
  if (i % 2 == 0)
  {
    // Adding the number to the even sum
    evenSum += int.Parse(Console.ReadLine());
  }
  else
  {
    // Adding the number to the odd sum
    oddSum += int.Parse(Console.ReadLine());
  }
}

// Check if the sums are equal
if (evenSum == oddSum)
{
  // Printing the result to the user
  Console.WriteLine("Yes");
  Console.WriteLine($"Sum = {evenSum}");
}
else
{
  // Printing the result to the user
  Console.WriteLine("No");
  Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
}