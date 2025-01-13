//User Input
int restDays = int.Parse(Console.ReadLine());

//Known data
int normPlayTime = 30000;
int workPlayTime = 63;
int restPlayTime = 127;
//Working days
double workingDays = 365 - restDays;

//Actual time for play
double actualTimeForPlay = (workingDays * workPlayTime) + (restDays * restPlayTime);

//Norm difference
double normDifference = normPlayTime - actualTimeForPlay;

//Minutes to hours for the norm
double normHours = Math.Floor(normDifference / 60);
double normMinutes = normDifference % 60;

//Minutes and hours for the play time
double playTimeHours = Math.Floor(actualTimeForPlay / 60);
double playTimeMinutes = actualTimeForPlay % 60;

//Checking if the time for play is more than the norm for this year
if (normDifference > normPlayTime)
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{normHours} hours and {normMinutes} minutes more for play");
}
else if (normDifference < normPlayTime)
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{playTimeHours} hours and {playTimeMinutes} minutes less for play");
}