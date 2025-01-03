string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double studioPrice = 0.0;
double apartmentPrice = 0.0;
double discountStudio = 0.0;
double discountApartment = 0.0;

if (month == "May" || month == "October")
{
    studioPrice = nights * 50.00;
    apartmentPrice = nights * 65.00;

    if (nights > 14)
    {
        discountStudio = 0.30;
        discountApartment = 0.10;

        studioPrice = studioPrice - (studioPrice * discountStudio);
        apartmentPrice = apartmentPrice - (apartmentPrice * discountApartment);
    }
    else if (nights > 7)
    {
        discountStudio = 0.05;
        studioPrice = studioPrice - (studioPrice * discountStudio);
    }
}
else if (month == "June" || month == "September")
{
    studioPrice = nights * 75.20;
    apartmentPrice = nights * 68.70;

    if (nights > 14)
    {
        discountStudio = 0.20;
        discountApartment = 0.10;

        studioPrice = studioPrice - (studioPrice * discountStudio);
        apartmentPrice = apartmentPrice - (apartmentPrice * discountApartment);
    }
}
else if (month == "July" || month == "August")
{
    studioPrice = nights * 76.00;
    apartmentPrice = nights * 77.00;

    if (nights > 14)
    {
        discountApartment = 0.10;
        apartmentPrice = apartmentPrice - (apartmentPrice * discountApartment);
    }
}

Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
Console.WriteLine($"Studio: {studioPrice:f2} lv.");