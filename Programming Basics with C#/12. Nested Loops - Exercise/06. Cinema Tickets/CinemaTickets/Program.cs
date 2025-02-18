// Creating variables for later use
int totalTickets = 0;
int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;

// Creating a while loop to circle through the movie, tickets, and seats
while (true)
{
  // user inputs the movie's name
  string movieName = Console.ReadLine();

  // Checking to see if the movie name is Finish
  if (movieName == "Finish")
    // If the movie name is Finish, break the loop
    break;

  // User Inputs the free seats
  int freeSeats = int.Parse(Console.ReadLine());

  // Creating a counter to store the current tickets
  int currentTickets = 0;

  // Checking to see if the current tickets are less than the free seats
  while (currentTickets < freeSeats)
  {
    // User inputs the ticket type
    string ticketType = Console.ReadLine();

    // If the ticket type is END
    if (ticketType == "End")
      break; // Break the loop

    // Creating a switch case to check what type is the ticket
    switch (ticketType)
    {
      case "student":
        studentTickets++;
        break;
      case "standard":
        standardTickets++;
        break;
      case "kid":
        kidTickets++;
        break;
    }
    // Adding plus one for each counted ticket
    currentTickets++;
  }
  
  // Calculating the percentage of seats that have been occupied.
  double hallOccupancy = (currentTickets * 100.0) / freeSeats;

  // Printing the name of the movie and at what percentage it is occupied.
  Console.WriteLine($"{movieName} - {hallOccupancy:F2}% full.");
}
// Adding the student, standard, and kid tickets to a total
totalTickets = studentTickets + standardTickets + kidTickets;

// Printing the result to the Console.
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{(studentTickets * 100.0 / totalTickets):F2}% student tickets.");
Console.WriteLine($"{(standardTickets * 100.0 / totalTickets):F2}% standard tickets.");
Console.WriteLine($"{(kidTickets * 100.0 / totalTickets):F2}% kids tickets.");