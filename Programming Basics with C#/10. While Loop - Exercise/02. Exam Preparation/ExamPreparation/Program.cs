// User input
int failedThreshold = int.Parse(Console.ReadLine());

// Variables for later use in the while loop
int failedTimes = 0;
int solvedProblemsCount = 0;
double gradeSum = 0;

// Variables for the last problem and if the student is failed
string lastProblem = "";
bool isFailed = true;

// While loop that will continue until the student fails the threshold number of times
while (failedTimes < failedThreshold)
{
    string problemName = Console.ReadLine();
    if   (problemName == "Enough")
    {
        isFailed = false;
        break;
    }
    int grade = int.Parse(Console.ReadLine());
    if (grade <= 4) // If the grade is below 4, the student failed the problem
    {
        failedTimes++;
    }
    // If the grade is above 4, the student solved the problem
    gradeSum += grade;
    solvedProblemsCount++;
    lastProblem = problemName;
}

if (isFailed)
{
    Console.WriteLine($"You need a break, {failedTimes} poor grades.");
}
else
{
    Console.WriteLine($"Average score: {gradeSum / solvedProblemsCount:F2}");
    Console.WriteLine($"Number of problems: {solvedProblemsCount}");
    Console.WriteLine($"Last problem: {lastProblem}");
}