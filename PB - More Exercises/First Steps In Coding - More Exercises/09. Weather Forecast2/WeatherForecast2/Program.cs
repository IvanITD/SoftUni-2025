double celcius = double.Parse(Console.ReadLine());

if (celcius >= 26.00 && celcius <= 35.00)
{
    Console.WriteLine("Hot");
}
else if (celcius >= 20.1 && celcius <= 25.9)
{
    Console.WriteLine("Warm");
}
else if (celcius >= 15.00 && celcius <= 20.00)
{
    Console.WriteLine("Mild");
}
else if (celcius >= 12.00 && celcius <= 14.9)
{
    Console.WriteLine("Cool");
}
else if (celcius >= 5.00 && celcius <= 11.9)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("unknown");
}