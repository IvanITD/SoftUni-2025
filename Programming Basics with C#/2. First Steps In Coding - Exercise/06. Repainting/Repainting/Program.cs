//User inputs
int nylonAmount = int.Parse(Console.ReadLine());
int paintLiters = int.Parse(Console.ReadLine());
int thinnerLiters = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

//Price for each product
double nylonPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5.00;

//calculations
double nylonTotalPrice = (nylonAmount + 2) * nylonPrice; // +2 for extra nylon
double paintLitersTotalPrice = (paintLiters + (paintLiters * 0.10)) * paintPrice;  // +10% for extra paint
double thinnerTotalPrice = thinnerLiters * thinnerPrice;
double bagPrice = 0.40; // bag price
double materialPrice = nylonTotalPrice + paintLitersTotalPrice + thinnerTotalPrice + bagPrice;

//Workers money
double workersMoney = (materialPrice * 0.30) * hours;

//Total Price
double TotalPrice = materialPrice + workersMoney;

//Output
Console.WriteLine(TotalPrice);