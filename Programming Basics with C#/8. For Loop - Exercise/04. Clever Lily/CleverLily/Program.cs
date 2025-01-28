// User input
int LilyAge = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int oneToyPrice = int.Parse(Console.ReadLine());

// Variables for later used
double money = 0;
int receivedToys = 0;
int receivedMoney = 0;

// Loop through the years
for (int currentAge = 1; currentAge <= LilyAge; currentAge++)
{
  // If the year is even, add 10 to the money
  if (currentAge % 2 == 1)
  {
    receivedToys++;
  }
  else if (currentAge % 2 == 0)
  {
    receivedMoney += 10;
    money += receivedMoney;

    // Here Lily's brother takes 1 lv. from her
    money--;
  }
}

// Now we calculate the total money from the toys that Lily sold
money += receivedToys * oneToyPrice;

// Check if the money is enough for Lily to buy the washing machine
if (money >= washingMachinePrice)
{
  // Creating a variable for the remaining money
  double remainingMoney = money - washingMachinePrice;
  // Printing the result
  Console.WriteLine($"Yes! {remainingMoney:F2}");
}
else
{
  // Creating a variable for the needed money
  double neededMoney = washingMachinePrice - money;
  // Printing the result
  Console.WriteLine($"No! {neededMoney:F2}");
}