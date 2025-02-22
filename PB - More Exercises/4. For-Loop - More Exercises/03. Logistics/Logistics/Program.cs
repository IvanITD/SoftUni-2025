// User Input
int cargoAmount = int.Parse(Console.ReadLine());

// Variables to store the values for later use
double pricePerTon = 0;
double totalPrice = 0;
double microbus = 0;
double truck = 0;
double train = 0;

// Creating a for loop to circle through day and check the tonnage
for (int i = 0; i < cargoAmount; i++)
{
  // Receiving input for the cargo tonnage
  int cargoTonnage = int.Parse(Console.ReadLine());

  
  if (cargoTonnage <= 3) // Checking to see if the tonnage is less or equal to 3
  {
    // Adding the tonnage to the microbus and calculating the price
    microbus += cargoTonnage;
    pricePerTon += cargoTonnage * 200;
  }
  else if (cargoTonnage <= 11) // Checking to see if the tonnage is less or equal to 11
  {
    // Adding the tonnage to the truck and calculating the price
    truck += cargoTonnage;
    pricePerTon += cargoTonnage * 175;
  }
  else // Checking to see if the tonnage is more or equal to 12
  {
    // Adding the tonnage to the train and calculating the price
    train += cargoTonnage;
    pricePerTon += cargoTonnage * 120;
  }

  // Calculating the total price
  totalPrice += cargoTonnage;

}

// Calculating the average price
double averagePrice = pricePerTon / totalPrice;

// Printing the results
Console.WriteLine($"{averagePrice:f2}"); // Average Price
Console.WriteLine($"{microbus / totalPrice * 100:f2}%"); // Tonnage Percentage for Microbus
Console.WriteLine($"{truck / totalPrice * 100:f2}%"); // Tonnage Percentage for Truck
Console.WriteLine($"{train / totalPrice * 100:f2}%"); // Tonnage Percentage for Train