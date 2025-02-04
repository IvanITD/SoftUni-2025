// User Input
string favoriteBook = Console.ReadLine();

// Counter for books
int bookCounter = 0;

// While Loop
while (true)
{
    // User Checks Books
    string book = Console.ReadLine();
    
    // Book counter
    bookCounter++;


    // If the book is found
    if (book == favoriteBook)
    {
        Console.WriteLine($"You checked {bookCounter} books and found it.");
        break;
    }
    else if (book == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {bookCounter} books.");
        break;
    }   
}