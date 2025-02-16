// Input values
double partyPrice = double.Parse(Console.ReadLine());
int loveMessagesCount = int.Parse(Console.ReadLine());
int waxRosesCount = int.Parse(Console.ReadLine());
int keychainsCount = int.Parse(Console.ReadLine());
int caricaturesCount = int.Parse(Console.ReadLine());
int fortuneSurprisesCount = int.Parse(Console.ReadLine());

// Item prices
double loveMessagePrice = 0.60;
double waxRosePrice = 7.20;
double keychainPrice = 3.60;
double caricaturePrice = 18.20;
double fortuneSurprisePrice = 22.00;

// Calculate total price before any discount
double totalPrice = (loveMessagesCount * loveMessagePrice) +
                    (waxRosesCount * waxRosePrice) +
                    (keychainsCount * keychainPrice) +
                    (caricaturesCount * caricaturePrice) +
                    (fortuneSurprisesCount * fortuneSurprisePrice);

// Check if there's a discount
if (loveMessagesCount + waxRosesCount + keychainsCount + caricaturesCount + fortuneSurprisesCount >= 25)
{
  totalPrice *= 0.65; // Apply 35% discount
}

// Hosting cost (10% of the total price)
double hostingCost = totalPrice * 0.10;

// Final amount after subtracting hosting costs
double finalProfit = totalPrice - hostingCost;

// Output the result
if (finalProfit >= partyPrice)
{
  Console.WriteLine($"Yes! {finalProfit - partyPrice:F2} lv left.");
}
else
{
  Console.WriteLine($"Not enough money! {partyPrice - finalProfit:F2} lv needed.");
}