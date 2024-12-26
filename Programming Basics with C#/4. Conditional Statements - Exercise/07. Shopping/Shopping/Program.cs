double peterBudget = double.Parse(Console.ReadLine());
int GPUAmount = int.Parse(Console.ReadLine());
int CPUAmount = int.Parse(Console.ReadLine());
int RAMAmount = int.Parse(Console.ReadLine());

//Part prices
double GPUPrice = GPUAmount * 250;
double CPUPrice = CPUAmount * (GPUPrice * 0.35);
double RAMPrice = RAMAmount * (GPUPrice * 0.10);

//Total Part Price
double totalPartPrice = GPUPrice + CPUPrice + RAMPrice;

//Check if GPU amount is bigger than CPU amount
if(GPUAmount > CPUAmount)
{
    //15% discount on total price
    totalPartPrice = totalPartPrice - (totalPartPrice * 0.15);
}


//Check if Peter has enough money
if (peterBudget >= totalPartPrice)
{
    Console.WriteLine($"You have {peterBudget - totalPartPrice:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {totalPartPrice - peterBudget:f2} leva more!");
}