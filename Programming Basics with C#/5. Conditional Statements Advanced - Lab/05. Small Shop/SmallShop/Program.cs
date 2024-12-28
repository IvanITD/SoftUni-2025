//User Input
string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

//Declare variable for later use
double total = 0.0;

//Check which City
switch (city)
{
    //Check which product
    case "Sofia":
        switch (product)
        {
            case "coffee":
                total = quantity * 0.50;
                break;

            case "water":
                total = quantity * 0.80;
                break;

            case "beer":
                total = quantity * 1.20;
                break;

            case "sweets":
                total = quantity * 1.45;
                break;

            case "peanuts":
                total = quantity * 1.60;
                break;
        }
        break;




    case "Plovdiv":
        switch (product)
        {
            case "coffee":
                total = quantity * 0.40;
                break;

            case "water":
                total = quantity * 0.70;
                break;

            case "beer":
                total = quantity * 1.15;
                break;

            case "sweets":
                total = quantity * 1.30;
                break;

            case "peanuts":
                total = quantity * 1.50;
                break;
        }
        break;



    case "Varna":
        switch (product)
        {
            case "coffee":
                total = quantity * 0.45;
                break;

            case "water":
                total = quantity * 0.70;
                break;

            case "beer":
                total = quantity * 1.10;
                break;

            case "sweets":
                total = quantity * 1.35;
                break;

            case "peanuts":
                total = quantity * 1.55;
                break;
        }
        break;
}

//Print the total
Console.WriteLine(total);