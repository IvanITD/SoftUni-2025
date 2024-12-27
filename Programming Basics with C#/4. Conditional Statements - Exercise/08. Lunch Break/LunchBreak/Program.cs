//User Input
string movieName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

//Calculating lunch and relaxation time
double lunchTime = breakDuration / 8.0;
double relaxTime = breakDuration / 4.0;

//Calculating how much free time is left.
double freeTime = breakDuration - lunchTime - relaxTime;

//Checking if the time is enough to watch the movie.
if(freeTime >= episodeDuration)
{
    //Output
    Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(freeTime - episodeDuration)} minutes free time.");
}
else
{
    //Output
    Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(episodeDuration - freeTime)} more minutes.");
}