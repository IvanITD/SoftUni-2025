//User Inputs
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double usedPercentOfArea = double.Parse(Console.ReadLine());

//Calculations of each area
double volume = length * width * height;

// 1 Liter = 0.001 m3
double volumeInLiters = volume * 0.001;

//Calculations of used space
double usedSpace = usedPercentOfArea / 100;

//Needed liters of water
double neededLiters = volumeInLiters * (1 - usedSpace);

//Output
Console.WriteLine(neededLiters);