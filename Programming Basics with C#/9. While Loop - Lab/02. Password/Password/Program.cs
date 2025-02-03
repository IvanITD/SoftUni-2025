// User input
string username = Console.ReadLine();
string password = Console.ReadLine();

// While loop
while (true)
{
    // User input
    string input = Console.ReadLine();

    // If the input is the password, print "Welcome {username}!" and break the loop
    if (input == password)
    {
        // Welcome the user and break the loop
        Console.WriteLine($"Welcome {username}!");
        break;
    }
}