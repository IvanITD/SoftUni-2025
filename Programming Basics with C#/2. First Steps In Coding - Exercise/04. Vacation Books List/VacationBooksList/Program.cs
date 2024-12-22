//User Inputs
int pagesAmount = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

//Total time to read the book
int totalTime = pagesAmount / pagesPerHour;

//Needed hours per day
int neededHoursPerDay = totalTime / days;

//Output
Console.WriteLine(neededHoursPerDay);