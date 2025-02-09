// User Input
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

// Calculating the total pieces of cake
int totalPieces = width * length;

// While loop to check if there is any cake left
while (totalPieces > 0)
{
  // User Input
  string command = Console.ReadLine();

  // If the command is "STOP", break the loop
  if (command == "STOP")
  {
    // Printing the message
    Console.WriteLine($"{totalPieces} pieces are left.");
    break;
  }

  // Parsing the command to an integer
  int pieces = int.Parse(command);

  // Subtracting the pieces from the total pieces
  totalPieces -= pieces;

  // If the total pieces are less than 0, print the message and break the loop
  if (totalPieces <= 0)
  {
    // Printing the message and breaking the loop
    Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
    break;
  }
}