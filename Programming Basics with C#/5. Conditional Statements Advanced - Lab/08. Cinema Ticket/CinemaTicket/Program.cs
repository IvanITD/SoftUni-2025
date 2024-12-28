//User Input
string dayFromWeek = Console.ReadLine();

//Check which day is it!
switch (dayFromWeek)
{
    case "Monday":
    case "Tuesday":
    case "Friday":
        Console.WriteLine("12");
        break;

    case "Wednesday":
    case "Thursday":
        Console.WriteLine("14");
        break;

    case "Saturday":
    case "Sunday":
        Console.WriteLine("16");
        break;
}