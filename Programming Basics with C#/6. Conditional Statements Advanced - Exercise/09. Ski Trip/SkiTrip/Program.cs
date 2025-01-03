//User Inputs
int dayStay = int.Parse(Console.ReadLine());
string placeType = Console.ReadLine();
string grade = Console.ReadLine();

int perNight = dayStay - 1;

//Place prices
double roomForOnePerson = perNight * 18.00;
double apartment = perNight * 25.00;
double presidentApartment = perNight * 35.00;

// Variables for later use
double discount = 0.0;
double total = 0.0;
double reward = 0.0;

if (dayStay < 10)
{
    if (placeType == "room for one person")
    {
        // no discount
        total = roomForOnePerson;
    }
    else if (placeType == "apartment")
    {
        // 30% discount
        discount = 0.30;
        total = apartment - (apartment * discount);
    }
    else if (placeType == "president apartment")
    {
        // 10% discount
        discount = 0.10;
        total = presidentApartment - (presidentApartment * discount);
    }
}
else if (dayStay >= 10 && dayStay <= 15)
{
    if (placeType == "room for one person")
    {
        // no discount
        total = roomForOnePerson;
    }
    else if (placeType == "apartment")
    {
        // 35% discount
        discount = 0.35;
        total = apartment - (apartment * discount);
    }
    else if (placeType == "president apartment")
    {
        // 15% discount
        discount = 0.15;
        total = presidentApartment - (presidentApartment * discount);
    }
}
else if (dayStay > 15)
{
    if (placeType == "room for one person")
    {
        // no discount
        total = roomForOnePerson;
    }
    else if (placeType == "apartment")
    {
        // 50% discount
        discount = 0.50;
        total = apartment - (apartment * discount);
    }
    else if (placeType == "president apartment")
    {
        // 20% discount
        discount = 0.20;
        total = presidentApartment - (presidentApartment * discount);
    }
}

if (grade == "positive")
{
    reward = 0.25;
    total = total + (total * reward);
}
else if (grade == "negative")
{
    discount = 0.10;
    total = total - (total * discount);
}

Console.WriteLine($"{total:f2}");