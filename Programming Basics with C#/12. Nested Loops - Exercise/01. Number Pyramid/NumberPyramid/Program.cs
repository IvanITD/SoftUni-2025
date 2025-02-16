// User Input
int n = int.Parse(Console.ReadLine());

int currentNumber = 0;
bool isBigger = false;

// Creating a for loop for the rows
for (int row = 1; row <= n; row++)
{
  // Creating a for loop for the columns
  for (int columns = 1; columns <= row; columns++)
  {
    // Adding plus 1 to the current current Number
    currentNumber++;

    // Checking to see if the current number is bigger than 7
    if (currentNumber > n)
    {
      isBigger = true;
      break; // Breaking the loop
    }

    // Printing the output
    Console.Write($"{currentNumber} ");

    // Checking to see if the current number is bigger than 7, in order this time if the requirement is met, to break the loop
    if (currentNumber > n)
    {
      isBigger = true;
      break; // Breaking the loop
    }
  }
  
  // Creating the next row
  Console.WriteLine();
}