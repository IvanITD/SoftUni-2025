// User Input
int groups = int.Parse(Console.ReadLine());

// Variables for later use
int people = 0;
double totalPeople = 0.0;

// The places where the people will climb
int musala = 0;
int monblan = 0;
int kilimandjaro = 0;
int k2 = 0;
int everest = 0;

// For every group to check the number of people
for (int i = 1; i <= groups; i++)
{
    // User Input
    people = int.Parse(Console.ReadLine());
    
    // Sum the total amount of people from every group
    totalPeople += people;

    // Check how many people are in a group
    if (people <= 5)
    {
        // Add the people to the musala mountain
        musala += people;
    }
    else if (people >= 6 && people <= 12)
    {
        // Add the people to the monblan mountain
        monblan += people;
    }
    else if (people >= 13 && people <= 25)
    {
        // Add the people to the kilimandjaro mountain
        kilimandjaro += people;
    }
    else if (people >= 26 && people <= 40)
    {
        // Add the people to the k2 mountain
        k2 += people;
    }
    else if (people >= 41)
    {
        // Add the people to the everest mountain
        everest += people;
    }
}

// Calculate the percentage of people for every mountain
double musalaPercentage = (musala / totalPeople) * 100;
double monblanPercentage = (monblan / totalPeople) * 100;
double kilimandjaroPercentage = (kilimandjaro / totalPeople) * 100;
double k2Percentage = (k2 / totalPeople) * 100;
double everestPercentage = (everest / totalPeople) * 100;

// Print the percentage of people for every mountain
Console.WriteLine($"{musalaPercentage:f2}%");
Console.WriteLine($"{monblanPercentage:f2}%");
Console.WriteLine($"{kilimandjaroPercentage:f2}%");
Console.WriteLine($"{k2Percentage:f2}%");
Console.WriteLine($"{everestPercentage:f2}%");