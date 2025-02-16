// User Input
        int numStudents = int.Parse(Console.ReadLine());
        
        // Variables to store the counts for each grade group and total sum of grades
        int topStudentsCount = 0;
        int between4And499Count = 0;
        int between3And399Count = 0;
        int failCount = 0;
        double totalGradesSum = 0;

        // Loop to process the grades for each student
        for (int i = 0; i < numStudents; i++)
        {
            double grade = double.Parse(Console.ReadLine());
            totalGradesSum += grade;

            if (grade >= 5.00)
            {
                topStudentsCount++;
            }
            else if (grade >= 4.00)
            {
                between4And499Count++;
            }
            else if (grade >= 3.00)
            {
                between3And399Count++;
            }
            else
            {
                failCount++;
            }
        }

        // Calculate the percentages
        double topStudentsPercentage = (topStudentsCount * 100.0) / numStudents;
        double between4And499Percentage = (between4And499Count * 100.0) / numStudents;
        double between3And399Percentage = (between3And399Count * 100.0) / numStudents;
        double failPercentage = (failCount * 100.0) / numStudents;

        // Calculate the average grade
        double averageGrade = totalGradesSum / numStudents;

        // Print the results to the Console
        Console.WriteLine($"Top students: {topStudentsPercentage:F2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {between4And499Percentage:F2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {between3And399Percentage:F2}%");
        Console.WriteLine($"Fail: {failPercentage:F2}%");
        Console.WriteLine($"Average: {averageGrade:F2}");