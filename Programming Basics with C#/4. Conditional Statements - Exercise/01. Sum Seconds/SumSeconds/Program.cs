//User Input
int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

//Sum of the times
int totalTime = firstTime + secondTime + thirdTime;

//Turn the total time into minutes and seconds
double minutes = totalTime / 60;
double seconds = totalTime % 60;

//Check if the seconds are less than 10 in order to add a 0 in front of them
if (seconds < 10)
{
    //Print the output
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    //Print the output
    Console.WriteLine($"{minutes}:{seconds}");
}