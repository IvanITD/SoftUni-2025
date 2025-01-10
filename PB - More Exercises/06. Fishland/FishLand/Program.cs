// User Inputs
double mackerelPricePerKg = double.Parse(Console.ReadLine()); // Цена на скумрията за килограм
double spartPricePerKg = double.Parse(Console.ReadLine()); //  Цена на цацата за килограм
double bonitoKg = double.Parse(Console.ReadLine()); // Количество паламуд
double safridKg = double.Parse(Console.ReadLine()); // Количество сафрид
int musselsKg = int.Parse(Console.ReadLine()); // Количество миди

// Palamud Calculations and Price
double bonitoPrice = mackerelPricePerKg + (mackerelPricePerKg * 0.60);
double bonitoSum = bonitoKg * bonitoPrice;

// Safrid Calculations and Price
double safridPrice = spartPricePerKg + (spartPricePerKg * 0.80);
double safridSum = safridKg * safridPrice;

// Midi Calculations and Price
double musselsPrice = 7.50;
double musselsSum = musselsKg * musselsPrice;

// Total Sum
double totalSum = bonitoSum + safridSum + musselsSum;

// Output
Console.WriteLine($"{totalSum:f2}");