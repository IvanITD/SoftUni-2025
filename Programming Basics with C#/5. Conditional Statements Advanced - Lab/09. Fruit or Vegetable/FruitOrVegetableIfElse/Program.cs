//User Input
string product = Console.ReadLine();

//Check if product is fruit
if(product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon" || product == "grapes")
{
    Console.WriteLine("fruit");
}
//Check if product is vegetable
else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
{
    Console.WriteLine("vegetable");
}
//If product is not fruit or vegetable
else
{
    Console.WriteLine("unknown");
}