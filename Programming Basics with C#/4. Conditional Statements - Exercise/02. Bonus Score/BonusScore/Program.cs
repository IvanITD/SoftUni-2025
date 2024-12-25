//User Inputs
int number = int.Parse(Console.ReadLine());

double bonusPoints = 0.0;
//Check on how much are the points
if (number <= 100)
{
    bonusPoints = 5; //5 points

    //More bonus points
    if (number % 2 == 0)
    {
        bonusPoints += 1; //+1 point
    }
    else if (number % 10 == 5)
    {
        bonusPoints += 2; //+2 points
    }

}
else if (number > 1000)
{
    bonusPoints = number * 0.1; //10% of the number

    //More bonus points
    if (number % 2 == 0)
    {
        bonusPoints += 1; //+1 point
    }
    else if (number % 10 == 5)
    {
        bonusPoints += 2; //+2 points
    }
}
else if (number > 100 || number <= 1000)
{
    bonusPoints = number * 0.2; //20% of the number

    //More bonus points
    if (number % 2 == 0)
    {
        bonusPoints += 1; //+1 point
    }
    else if (number % 10 == 5)
    {
        bonusPoints += 2; //+2 points
    }
}



//Sum the number with the points
double sum = number + bonusPoints;

//Print the output
Console.WriteLine(bonusPoints); // Print the bonus points
Console.WriteLine(sum); // Print the total sum