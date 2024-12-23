//User inputs
int nylonAmount = int.Parse(Console.ReadLine());
int paintLiters = int.Parse(Console.ReadLine());
int thinnerLiters = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

//Price for each product
double nylonPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5.00;

//More materials needed
double moreNylon = nylonAmount + 2;
double morePaint = paintLiters * 0.10;
double bagPrice = 0.40;

//Calculations
double nylonTotalPrice = (nylonAmount + moreNylon) * nylonPrice; // + 2 for more nylon
double paintTotalPrice = (paintLiters * morePaint) * paintPrice;
double thinnerTotalPrice = thinnerLiters * thinnerPrice;

//Total Price
double sumPrice = nylonTotalPrice + paintTotalPrice + thinnerTotalPrice;

//money for workers
double workersPrice = sumPrice * 0.30;
double workersTotalPrice = hours * workersPrice;

//TotalPrice
double totalPrice = sumPrice + workersTotalPrice + bagPrice;

//Output
Console.WriteLine(totalPrice);