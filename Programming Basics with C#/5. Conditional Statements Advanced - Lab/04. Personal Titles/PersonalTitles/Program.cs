//User Inputs
double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

//Check if the user is a male, man or a boy, and a female, girl or a woman
switch (gender)
{
    case 'm':
    switch (age)
    {
        case >=16:
        Console.WriteLine("Mr.");
        break;
        
        case <16:
        Console.WriteLine("Master");
        break;
    }
    break;

    case 'f':
    switch (age)
    {
        case >=16:
        Console.WriteLine("Ms.");
        break;

        case <16:
        Console.WriteLine("Miss");
        break;
    }
    break;
}