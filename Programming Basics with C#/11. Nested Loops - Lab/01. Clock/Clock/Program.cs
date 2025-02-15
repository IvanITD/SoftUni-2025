// Creating a for loop that prints all the hours and minutes of the day.
for (int h = 0; h <= 23; h++)
{
    for (int m = 0; m <= 59; m++)
    {
        // Printing the result in the format HH:MM
        Console.WriteLine($"{h}:{m}");
    }
}