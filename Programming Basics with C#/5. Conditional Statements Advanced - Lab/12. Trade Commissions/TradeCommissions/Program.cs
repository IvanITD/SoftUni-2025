string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());


if (city == "Sofia")
{
    if (sales >= 0 && sales <= 500)
    {
        sales = sales * 0.05;
    }
    else if (sales > 500 && sales <= 1000)
    {
        sales = sales * 0.07;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        sales = sales * 0.08;
    }
    else if (sales > 10000)
    {
        sales = sales * 0.12;
    }
    else
    {
        Console.WriteLine("error");
        return;
    }
}
else if (city == "Varna")
{
    if (sales >= 0 && sales <= 500)
    {
        sales = sales * 0.045;
    }
    else if (sales > 500 && sales <= 1000)
    {
        sales = sales * 0.075;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        sales = sales * 0.10;
    }
    else if (sales > 10000)
    {
        sales = sales * 0.13;
    }
    else
    {
        Console.WriteLine("error");
        return;
    }
}
else if (city == "Plovdiv")
{
    if (sales >= 0 && sales <= 500)
    {
        sales = sales * 0.055;
    }
    else if (sales > 500 && sales <= 1000)
    {
        sales = sales * 0.08;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        sales = sales * 0.12;
    }
    else if (sales > 10000)
    {
        sales = sales * 0.145;
    }
    else
    {
        Console.WriteLine("error");
        return;
    }
}
else
{
    Console.WriteLine("error");
    return;
}

Console.WriteLine($"{sales:f2}");