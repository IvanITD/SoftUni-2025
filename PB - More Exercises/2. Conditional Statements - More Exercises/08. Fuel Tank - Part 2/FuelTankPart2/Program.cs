// User Input
string fuelType = Console.ReadLine(); // Could be "Gas", "Gasoline" or "Diesel"
double fuelQuantity = double.Parse(Console.ReadLine()); // In liters
string clubCardCheck = Console.ReadLine(); // Could be "Yes" or "No"

//Fuel Prices
double gasolinePrice = 2.22;
double dieselPrice = 2.33;
double gasPrice = 0.93;

double clubCard = 0.0;
double clubCardDiscount = 0.0;
double totalPrice = 0.0;
// Calculate the price for each fuel type after litters
double gasolineTotal = fuelQuantity * gasolinePrice;
double dieselTotal = fuelQuantity * dieselPrice;
double gasTotal = fuelQuantity * gasPrice;

// Check whether the Fuel is Gas, Gasoline or Diesel
if (fuelType == "Gas")
{
    // Check whether the user has a club card or not
    if (clubCardCheck == "Yes")
    {
        clubCard = 0.08;
        
        // 0.08 lv for a liter of gas
        clubCardDiscount = fuelQuantity * clubCard;

        // Now to remove the club card cents from the total price
        gasTotal -= clubCardDiscount;

        // Check whether the litres are more than 20 and 25
        if  (fuelQuantity >= 20 && fuelQuantity <= 25)
        {
            // 8% discount on the total price
            totalPrice = gasTotal - (gasTotal * 0.08);
        }
        else if (fuelQuantity > 25)
        {
            // 10% discount on the total Price
            totalPrice = gasTotal - (gasTotal * 0.10);
        }
        else
        {
            totalPrice = gasTotal;
        }
    }
    else if (clubCardCheck == "No")
    {
        // Check whether the litres are more than 20 and 25
        if  (fuelQuantity >= 20 && fuelQuantity <= 25)
        {
            // 8% discount on the total price
            totalPrice = gasTotal - (gasTotal * 0.08);
        }
        else if (fuelQuantity > 25)
        {
            // 10% discount on the total Price
            totalPrice = gasTotal - (gasTotal * 0.10);
        }
        else
        {
            totalPrice = gasTotal;
        }
    }
}
else if (fuelType == "Gasoline")
{
    // Check whether the user has a club card or not
    if (clubCardCheck == "Yes")
    {
        clubCard = 0.18;

        // 0.18 lv for a liter of gasoline
        clubCardDiscount = fuelQuantity * clubCard;

        // Now to remove the club card cents from the total price
        gasolineTotal -= clubCardDiscount;

        // Check whether the litres are more than 20 and 25
        if  (fuelQuantity >= 20 && fuelQuantity <= 25)
        {
            // 8% discount on the total price
            totalPrice = gasolineTotal - (gasolineTotal * 0.08);
        }
        else if (fuelQuantity > 25)
        {
            // 10% discount on the total Price
            totalPrice = gasolineTotal - (gasolineTotal * 0.10);
        }
        else
        {
            totalPrice = gasolineTotal;
        }
    }
    else if (clubCardCheck == "No")
    {
        // Check whether the litres are more than 20 and 25
        if  (fuelQuantity >= 20 && fuelQuantity <= 25)
        {
            // 8% discount on the total price
            totalPrice = gasolineTotal - (gasolineTotal * 0.08);
        }
        else if (fuelQuantity > 25)
        {
            // 10% discount on the total Price
            totalPrice = gasolineTotal - (gasolineTotal * 0.10);
        }
        else
        {
            totalPrice = gasolineTotal;
        }
    }
}
else if (fuelType == "Diesel")
{
    // Check whether the user has a club card or not
    if (clubCardCheck == "Yes")
    {
        clubCard = 0.12;

        // 0.12 lv for a liter of diesel
        clubCardDiscount = fuelQuantity * clubCard;

        // Now to remove the club card cents from the total price
        dieselTotal -= clubCardDiscount;

        // Check whether the litres are more than 20 and 25
        if  (fuelQuantity >= 20 && fuelQuantity <= 25)
        {
            // 8% discount on the total price
            totalPrice = dieselTotal - (dieselTotal * 0.08);
        }
        else if (fuelQuantity > 25)
        {
            // 10% discount on the total Price
            totalPrice = dieselTotal - (dieselTotal * 0.10);
        }
        else
        {
            totalPrice = dieselTotal;
        }
    }
    else if (clubCardCheck == "No")
    {
        // Check whether the litres are more than 20 and 25
        if  (fuelQuantity >= 20 && fuelQuantity <= 25)
        {
            // 8% discount on the total price
            totalPrice = dieselTotal - (dieselTotal * 0.08);
        }
        else if (fuelQuantity > 25)
        {
            // 10% discount on the total Price
            totalPrice = dieselTotal - (dieselTotal * 0.10);
        }
        else
        {
            totalPrice = dieselTotal;
        }
    }
}

Console.WriteLine($"{totalPrice:f2} lv.");