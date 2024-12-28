//User Input
string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

//Declare variable for later use
double total = 0.0;

//Check which city
if (city == "Sofia")
{
    //Check which product
    if (product == "coffee") //coffee price in Sofia is 0.50
    {
        total = quantity * 0.50;
    }
    else if (product == "water") //water price in Sofia is 0.80
    {
        total = quantity * 0.80;
    }
    else if (product == "beer") //beer price in Sofia is 1.20
    {
        total = quantity * 1.20;
    }
    else if (product == "sweets") //sweets price in Sofia is 1.45
    {
        total = quantity * 1.45;
    }
    else if (product == "peanuts") //peanuts price in Sofia is 1.60
    {
        total = quantity * 1.60;
    }
}
else if (city == "Plovdiv")
{
    //Check which product
    if (product == "coffee") //coffee price in Plovdiv is 0.40
    {
        total = quantity * 0.40;
    }
    else if (product == "water") //water price in Plovdiv is 0.70
    {
        total = quantity * 0.70;
    }
    else if (product == "beer") //beer price in Plovdiv is 1.15
    {
        total = quantity * 1.15;
    }
    else if (product == "sweets") //sweets price in Plovdiv is 1.30
    {
        total = quantity * 1.30;
    }
    else if (product == "peanuts") //peanuts price in Plovdiv is 1.50
    {
        total = quantity * 1.50;
    }

}
else if (city == "Varna")
{
    //Check which product
    if (product == "coffee") //coffee price in Varna is 0.45
    {
        total = quantity * 0.45;
    }
    else if (product == "water") //water price in Varna is 0.70
    {
        total = quantity * 0.70;
    }
    else if (product == "beer") //beer price in Varna is 1.10
    {
        total = quantity * 1.10;
    }
    else if (product == "sweets") //sweets price in Varna is 1.35
    {
        total = quantity * 1.35;
    }
    else if (product == "peanuts") //peanuts price in Varna is 1.55
    {
        total = quantity * 1.55;
    }
}

//Print result
Console.WriteLine(total);