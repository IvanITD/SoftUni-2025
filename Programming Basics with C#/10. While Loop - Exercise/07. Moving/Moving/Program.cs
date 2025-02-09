// User Input
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());


// Calculating the total volume of the box
int totalVolume = width * length * height;

// While loop to check if there is any space left
while (totalVolume > 0)
{
  // User Input
  string command = Console.ReadLine();

  // If the command is "Done" or the total volume is less than 0, break the loop
  if (command == "Done" || totalVolume <= 0)
  {
    // Printing the message
    Console.WriteLine($"{totalVolume} Cubic meters left.");
    break;
  }

  // Parsing the command to an integer  
  int boxes = int.Parse(command);

  // Subtracting the boxes from the total volume
  totalVolume -= boxes;

  // If the total volume is less than 0, print the message and break the loop
  if (totalVolume <= 0)
  {
    // Printing the message
    Console.WriteLine($"No more free space! You need {Math.Abs(totalVolume)} Cubic meters more.");
    break;
  }
}