// User Input
int studentsTotal = int.Parse(Console.ReadLine());


// Variables for later use
double topStudents = 0;
double goodStudents = 0;
double averageStudents = 0;
double failStudents = 0;
double averageGrade = 0;

// Looping through each student, according to the total of students
for (int i = 0; i < studentsTotal; i++)
{
  // User Input for each student
  double student = double.Parse(Console.ReadLine());

  // Checking the grade of the student
  if (student >= 5.00) // Checking if the student has a grade of 5 or more
  {
    topStudents++; // Adding the student to the topStudents

    // Calculating the average grade
    averageGrade += student;
  }
  else if (student >= 4.00 && student <= 4.99) // Checking if the student has a grade of 4 or more
  {
    goodStudents++; // Adding the student to the goodStudents

    // Calculating the average grade
    averageGrade += student;
  }
  else if (student >= 3.00 && student <= 3.99) // Checking if the student has a grade of 3 or more
  {
    averageStudents++; // Adding the student to the averageStudents

    // Calculating the average grade
    averageGrade += student;
  }
  else // Checking if the student has a grade of less than 3
  {
    failStudents++; // Adding the student to the failStudents 

    // Calculating the average grade
    averageGrade += student;
  }
}

// Calculating the average grade
averageGrade /= studentsTotal;

// Calculating the percentage of each student
topStudents = topStudents / studentsTotal * 100;
goodStudents = goodStudents / studentsTotal * 100;
averageStudents = averageStudents / studentsTotal * 100;
failStudents = failStudents / studentsTotal * 100;

// Printing the results
Console.WriteLine($"Top students: {topStudents:F2}%");
Console.WriteLine($"Between 4.00 and 4.99: {goodStudents:F2}%");
Console.WriteLine($"Between 3.00 and 3.99: {averageStudents:F2}%");
Console.WriteLine($"Fail: {failStudents:F2}%");
Console.WriteLine($"Average: {averageGrade:F2}");