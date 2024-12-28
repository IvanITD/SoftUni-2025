//User Input
int dayTime = int.Parse(Console.ReadLine());
string weekDay = Console.ReadLine();

//Check if dayTime is in working hours
switch (weekDay)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
    case "Saturday":
        if (dayTime >= 10 && dayTime <= 18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;

    case "Sunday":

        {
            Console.WriteLine("closed");
        }
        break;
}