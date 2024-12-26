//User Input
double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

//Ivan's time in seconds
double ivanTimeInSeconds = distanceInMeters * timeInSecondsForOneMeter;

//for every 15 meters Ivan adds 12.5 seconds to his time
double delay = Math.Floor(distanceInMeters / 15) * 12.5;

//Ivan's total time in seconds
double totalTimeInSeconds = ivanTimeInSeconds + delay;

//Check if Ivan's time is less than the record
if (totalTimeInSeconds < recordInSeconds)
{
    //Print the result
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeInSeconds:f2} seconds.");
}
else
{
    //Print the result
    Console.WriteLine($"No, he failed! He was {totalTimeInSeconds - recordInSeconds:f2} seconds slower.");
}

