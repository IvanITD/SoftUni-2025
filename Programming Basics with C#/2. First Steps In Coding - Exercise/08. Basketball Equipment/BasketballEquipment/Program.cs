//User Inputs
int yearlyFee = int.Parse(Console.ReadLine());

//Price of each equipment
double basketballShoes = yearlyFee - (yearlyFee * 0.40); // 40% of the yearly fee
double basketballClothes = basketballShoes - (basketballShoes * 0.20); // 20% cheaper than the shoes
double basketBall = basketballClothes / 4; // 1/4 of the basketball clothes
double basketballAccessories = basketBall / 5; // 1/5 of the basket ball

//Total Price
double totalPrice = yearlyFee + basketballShoes + basketballClothes + basketBall + basketballAccessories;

//Output
Console.WriteLine(totalPrice);
