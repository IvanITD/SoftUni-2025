// Read input
int stadiumCapacity = int.Parse(Console.ReadLine());
int totalFans = int.Parse(Console.ReadLine());

// Initialize sector counters
int sectorA = 0;
int sectorB = 0;
int sectorV = 0;
int sectorG = 0;

// Count fans in each sector
for (int i = 0; i < totalFans; i++)
{
  string sector = Console.ReadLine();

  switch (sector)
  {
    case "A":
      sectorA++;
      break;
    case "B":
      sectorB++;
      break;
    case "V":
      sectorV++;
      break;
    case "G":
      sectorG++;
      break;
      default:
      break;
  }
}

// Calculate percentages
double sectorAPercentage = (sectorA * 100.0) / totalFans;
double sectorBPercentage = (sectorB * 100.0) / totalFans;
double sectorVPercentage = (sectorV * 100.0) / totalFans;
double sectorGPercentage = (sectorG * 100.0) / totalFans;
double totalFansPercentage = (totalFans * 100.0) / stadiumCapacity;

// Print results in the correct order
Console.WriteLine($"{sectorAPercentage:f2}%");  // First sector A
Console.WriteLine($"{sectorBPercentage:f2}%");  // Then sector B
Console.WriteLine($"{sectorVPercentage:f2}%");  // Then sector V
Console.WriteLine($"{sectorGPercentage:f2}%");  // Then sector G
Console.WriteLine($"{totalFansPercentage:f2}%"); // Finally total percentage