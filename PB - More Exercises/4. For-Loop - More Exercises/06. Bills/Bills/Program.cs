// User Input
int months = int.Parse(Console.ReadLine());

// Creating variables for later use
double totalElectricity = 0;
double totalWater = 0;
double totalInternet = 0;
double totalOther = 0;

double waterBill = 20;
double internetBill = 15;

// Creating a for loop to circle through the months
for (int i = 0; i < months; i++)
{
    // Receiving user input for the electricity bill then adding a total of it
    double electricity = double.Parse(Console.ReadLine());
    totalElectricity += electricity;
    
    // Adding to the total of the water and internet bill
    totalWater += waterBill;
    totalInternet += internetBill;
    
    // Calculating all the bills together then adding them to the total other named variable
    double otherBills = (electricity + waterBill + internetBill) * 1.2;
    totalOther += otherBills;
}

// Calculating the average total per month
double averageBills = (totalElectricity + totalWater + totalInternet + totalOther) / months;

// Printing the result to the console
Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
Console.WriteLine($"Water: {totalWater:f2} lv");
Console.WriteLine($"Internet: {totalInternet:f2} lv");
Console.WriteLine($"Other: {totalOther:f2} lv");
Console.WriteLine($"Average: {averageBills:f2} lv");