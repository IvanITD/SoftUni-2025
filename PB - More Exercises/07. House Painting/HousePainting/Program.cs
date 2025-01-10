// User Input
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

// Side Walls
double sideWall = x * y;
double sideSquareWindow = 1.5;
double sideSquareWindowArea = sideSquareWindow * sideSquareWindow;
double twoSideWallsArea = (2 * sideWall) - (2 * sideSquareWindowArea);

// Back Walls
double backWall = x * x;
double frontDoor = 1.2 * 2;

// Front and back area together
double frontAndBackArea = (2 * backWall) - 2.4;

// Total Area
double totalArea = twoSideWallsArea + frontAndBackArea;

// Green Paint
double greenPaint = totalArea / 3.4;

// ROOF

// Two rectangles of the roof
double twoRectangles = 2 * (x * y);

// Two triangles of the roof
double twoTriangles = 2 * (x * h / 2);

// Total roof area
double totalRoofArea = twoRectangles + twoTriangles;

//Black Paint
double redPaint = totalRoofArea / 4.3;

Console.WriteLine($"{greenPaint:f2}"); // Litres green paint
Console.WriteLine($"{redPaint:f2}"); // Litres red paint


/* Dear User/Student, this task was a bit tricky, so I decided to leave a comment here, to help you understand what I did.
While you are solving this task make sure you are using the correct data type for the variables. The task is advising you to use integer for the inputs, but the problem is that the inputs
some times are more than just integers, so you'll need to use double. It's probably a mistake by the author of the task, but If you're not sure, you can check it yourself by applying your finished code
to the judge system. There you'll see that it doesn't give you 100% points. In that case for the user inputs just use double instead of Integer!*/