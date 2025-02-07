// User Input
int unsatisfactoryGrades = int.Parse(Console.ReadLine());

// Variables
int unsatisfactoryGradesCount = 0;
int solvedProblemsCount = 0;

// While Loop
while (true)
{
    // User Input for the task name and grade
    string taskName = Console.ReadLine();
    int grade = int.Parse(Console.ReadLine());

    // If the task name is "Enough"
    if (taskName == "Enough")
    {
        break;
    }

    // If the grade is unsatisfactory
    if (grade <= 4)
    {
        unsatisfactoryGradesCount++;
    }

    // If the unsatisfactory grades count is equal to the unsatisfactory grades
    if (unsatisfactoryGradesCount == grade)
    {
        Console.WriteLine($"You need a break, {unsatisfactoryGradesCount} poor grades.");
        break;
    }
    
    
    
}

