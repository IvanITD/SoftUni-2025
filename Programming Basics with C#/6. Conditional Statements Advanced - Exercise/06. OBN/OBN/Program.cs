int N1 = int.Parse(Console.ReadLine());
int N2 = int.Parse(Console.ReadLine());
char character = char.Parse(Console.ReadLine());

double sum = 0.0;

if (character == '+')
{
    sum = N1 + N2;

    if (sum % 2 == 0)
    {
        Console.WriteLine($"{N1} + {N2} = {sum} - even");
    }
    else
    {
        Console.WriteLine($"{N1} + {N2} = {sum} - odd");
    }

}
else if (character == '-')
{
    sum = N1 - N2;

    if (sum % 2 == 0)
    {
        Console.WriteLine($"{N1} - {N2} = {sum} - even");
    }
    else
    {
        Console.WriteLine($"{N1} - {N2} = {sum} - odd");
    }
}
else if (character == '*')
{
    sum = N1 * N2;

    if (sum % 2 == 0)
    {
        Console.WriteLine($"{N1} * {N2} = {sum} - even");
    }
    else
    {
        Console.WriteLine($"{N1} * {N2} = {sum} - odd");
    }
}
else if (character == '/')
{


    if (N1 == 0)
    {
        Console.WriteLine($"Cannot divide {N2} by zero");
    }
    else if (N2 == 0)
    {
        Console.WriteLine($"Cannot divide {N1} by zero");
    }
    else
    {
        sum = (double)N1 / N2;

        Console.WriteLine($"{N1} / {N2} = {sum:f2}");
    }
}
else if (character == '%')
{

    if (N1 == 0)
    {
        Console.WriteLine($"Cannot divide {N2} by zero");
    }
    else if (N2 == 0)
    {
        Console.WriteLine($"Cannot divide {N1} by zero");
    }
    else
    {
        sum = N1 % N2;
        Console.WriteLine($"{N1} % {N2} = {sum}");
    }
}