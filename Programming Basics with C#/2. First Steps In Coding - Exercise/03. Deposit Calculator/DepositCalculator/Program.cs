//User inputs
double depositSum = double.Parse(Console.ReadLine());
int depositPeriod = int.Parse(Console.ReadLine());
double yearPercent = double.Parse(Console.ReadLine());

//Calculations
double TotalSum = depositSum + depositPeriod * ((depositSum * yearPercent / 100) / 12);

//Output
Console.WriteLine(TotalSum);