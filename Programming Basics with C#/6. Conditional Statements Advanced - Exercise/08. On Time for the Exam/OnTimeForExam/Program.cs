int hourExam = int.Parse(Console.ReadLine());
int minExam = int.Parse(Console.ReadLine());
int hourArrival = int.Parse(Console.ReadLine());
int minArrival = int.Parse(Console.ReadLine());

int examTimeInMinutes = hourExam * 60 + minExam;
int arrivalTimeInMinutes = hourArrival * 60 + minArrival;

int timeDifference = arrivalTimeInMinutes - examTimeInMinutes;


if (timeDifference > 0)
{
    Console.WriteLine("Late");

    int hours = timeDifference / 60;
    int minutes = timeDifference % 60;

    if (hours > 0)
    {
        Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
    }
    else
    {
        Console.WriteLine($"{minutes} minutes after the start");
    }
}
else if (timeDifference >= -30)
{
    Console.WriteLine("On time");

    if (timeDifference < 0)
    {
        Console.WriteLine($"{Math.Abs(timeDifference)} minutes before the start");
    }
}
else
{
    Console.WriteLine("Early");

    int hours = Math.Abs(timeDifference) / 60;
    int minutes = Math.Abs (timeDifference) % 60;

    if (hours > 0)
    {
        Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
    }
    else
    {
        Console.WriteLine($"{minutes} minutes before the start");
    }
}