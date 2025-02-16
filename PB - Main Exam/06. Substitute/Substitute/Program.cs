// User Input
int K = int.Parse(Console.ReadLine());
int L = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

// Creating a variable to track the number of valid substitutions
int validSubstitutions = 0;

// Creating a for loop to check all possible combinations for the first and second player
for (int first1 = K; first1 <= 8; first1++)
{
  for (int first2 = 9; first2 >= L; first2--)
  {
    for (int second1 = M; second1 <= 8; second1++)
    {
      for (int second2 = 9; second2 >= N; second2--)
      {
        // Checking to see if both numbers have an even first digit and odd second digit
        if (first1 % 2 == 0 && first2 % 2 != 0 && second1 % 2 == 0 && second2 % 2 != 0)
        {
          // Checking to see if the two numbers are the same
          if (first1 == second1 && first2 == second2)
          {
            // Printing to the Console
            Console.WriteLine("Cannot change the same player.");
          }
          else
          {
            // Printing to the Console
            Console.WriteLine($"{first1}{first2} - {second1}{second2}");
            validSubstitutions++;
          }

          // Checking to see if the substitutions are equal to 6
          if (validSubstitutions == 6)
          {
            // If the substitutions are equal to 6, we break the loop.
            return;
          }
        }
      }
    }
  }
}
