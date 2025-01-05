//User Input
string text = Console.ReadLine();

//Variable for later use
int sum = 0;

//Check to see if the letter is a vowel and if yes add the value to the sum
for (int i = 0; i < text.Length; i++)
{
    char letter = text[i];

    switch (letter)
    {
        case 'a':
            sum += 1;
            break;

        case 'e':
            sum += 2;
            break;

        case 'i':
            sum += 3;
            break;

        case 'o':
            sum += 4;
            break;

        case 'u':
            sum += 5;
            break;
    }
}

Console.WriteLine(sum);