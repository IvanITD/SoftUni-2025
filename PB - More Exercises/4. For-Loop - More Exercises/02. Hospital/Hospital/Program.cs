// User Input
int period = int.Parse(Console.ReadLine());

// The amount of doctors
int doctors = 7;

// Day counter that keeps the day count
int dayCount = 0;

// Creating two variables for the treated and untreated patients
int treated = 0;
int untreated = 0;

// Creating a for loop that will circle through the days
for (int i = 1; i <= period; i++)
{
    // Adding plus one for each day
    dayCount++;
    
    /* Every third day we check to see if the untreated are more than the treated
    so we can add one more doctor*/
    if (dayCount == 3)
    {
        // Checking to see if the untreated are more than the treated
        if (untreated > treated)
        {
            doctors++;
        }

        // Here there should be a dayCount reset
        dayCount = 0;
    }

    int patients = int.Parse(Console.ReadLine());

    // Checking to see if the patients are equal or less than seven
    if (patients <= doctors)
    {
        treated += patients;
    }
    else
    {
        treated += doctors;
        untreated += (patients - doctors);
    }

}
// Print the treated and untreated patients
Console.WriteLine($"Treated patients: {treated}.");
Console.WriteLine($"Untreated patients: {untreated}.");