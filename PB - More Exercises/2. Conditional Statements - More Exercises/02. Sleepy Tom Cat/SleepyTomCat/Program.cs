// Play time norm
int playTimeNormPerYear = 30000;

// Play time for work days
int playTimeWorkDays = 63;
// Play time for rest days
int playTimeRestDays = 127;

// Year days
int yearDays = 365;

// User Input
int restDaysAmount = int.Parse(Console.ReadLine());

// Working Days
int workingDays = yearDays - restDaysAmount;

// Rest Days
int restDays = restDaysAmount * playTimeRestDays;

// Real time for playing
int realTimeForPlaying = (workingDays * playTimeWorkDays) + (restDaysAmount * playTimeRestDays);

// Difference
int difference = Math.Abs(playTimeNormPerYear - realTimeForPlaying);

// Difference in hours
int differenceHours = difference / 60;

// Difference in minutes
int differenceMinutes = difference % 60;

if (realTimeForPlaying > playTimeNormPerYear)
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{differenceHours} hours and {differenceMinutes} minutes more for play");
}
else if (realTimeForPlaying < playTimeNormPerYear)
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{differenceHours} hours and {differenceMinutes} minutes less for play");
}