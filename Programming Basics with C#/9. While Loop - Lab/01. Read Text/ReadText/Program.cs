// User input
string input = Console.ReadLine();

// While loop set to true to run indefinitely
while (true)
{
    if (input == "Stop")
    {
        // Break the loop if the input is "Stop"
        break;
    }
    // Print the input
    Console.WriteLine(input);

    // Read the next input
    input = Console.ReadLine();
}