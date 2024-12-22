//Receiving the input from the user
string name = Console.ReadLine();
int projectAmount = int.Parse(Console.ReadLine());

//Calculating the needed time
int neededTime = projectAmount * 3;

//Printing the result
Console.WriteLine($"The architect {name} will need {neededTime} hours to complete {projectAmount} project/s.");

