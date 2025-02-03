// User inputs his name
string name = Console.ReadLine();

// Variable to store the sum of the grades
double sumOfGrades = 0;

// Variable to store the number of grades
int numberOfGrades = 0;

// While loop to read the grades
while (true)
{
    // User inputs the grade
    double grade = double.Parse(Console.ReadLine());
    
    // If the grade is less than 4, the student is excluded
    if (grade < 4)
    {
        Console.WriteLine($"{name} has been excluded at {numberOfGrades + 1} grade");
        break;
    }
    
    // Add the grade to the sum of the grades
    sumOfGrades += grade;
    
    // Increment the number of grades
    numberOfGrades++;
    
    // If the number of grades is 12, the student is graduated
    if (numberOfGrades == 12)
    {
        // Print the average grade
        Console.WriteLine($"{name} graduated. Average grade: {sumOfGrades / numberOfGrades:F2}");
        break;
    }
}
