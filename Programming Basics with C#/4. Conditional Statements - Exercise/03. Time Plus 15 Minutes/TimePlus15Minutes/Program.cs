//User Input
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

//Calculating the minutes plus 15 minutes more
if (hours == 23 && minutes + 15 >= 60)
{
    hours = 0;
    minutes = (minutes + 15) - 60;

    //Adding the zero (0) in front of the minutes if they are less than 10
    if (minutes >= 0 && minutes < 10)
    {
        Console.WriteLine($"{hours}:0{minutes}");
    }
    else
    {
        Console.WriteLine($"{hours}:{minutes}");
    }
}
else if (minutes + 15 >= 60)
{
    hours++;
    minutes = (minutes + 15) - 60;

    //Adding the zero (0) in front of the minutes if they are less than 10
    if (minutes >= 0 && minutes < 10)
    {
        Console.WriteLine($"{hours}:0{minutes}");
    }
    else
    {
        Console.WriteLine($"{hours}:{minutes}");
    }
}
else
{
    minutes += 15;

    //Adding the zero (0) in front of the minutes if they are less than 10
    if (minutes >= 0 && minutes < 10)
    {
        Console.WriteLine($"{hours}:0{minutes}");
    }
    else
    {
        Console.WriteLine($"{hours}:{minutes}");
    }
}