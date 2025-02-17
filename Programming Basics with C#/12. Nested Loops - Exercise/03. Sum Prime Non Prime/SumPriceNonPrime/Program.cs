// Creating two variables. One for the prime numbers, and one for the non-prime numbers.
int primeSum = 0;
int nonPrimeSum = 0;

// Creating a while loop to read input until "stop" is entered.
string input = Console.ReadLine();

while (input != "stop")
{
  // Converting the string input into a number
  int number;
  bool isValidNumber = int.TryParse(input, out number);

  //Checking to see if the number is isValidNumber
  if (isValidNumber)
  {
    // Checking to see if the number is negative
    if (number < 0)
    {
      Console.WriteLine("Number is negative.");
    }
    else
    {
      // Checking to see if the number is prime
      bool isPrime = true;

      if (number <= 1)
      {
        // 0 and 1 are not prime
        isPrime = false;
      }
      else
      {
        // Checking to see if the number is divisible by any number from 2 to number 1
        for (int i = 2; i < number; i++)
        {
          if (number % i == 0)
          {
            // If a divisor is found, it means it's not prime
            isPrime = false;
            break; // Breaking the loop
          }
        }
      }
      
      // If the number is Prime, adding the number to appropriate sum
      if (isPrime)
      {
        primeSum += number;
      }
      else
      {
        nonPrimeSum += number;
      }
    }
  }

  // Here we're continuing with the input.
  input = Console.ReadLine();
}

// Printing the result to the Console
Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");