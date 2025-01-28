// User Input

int n = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

// Fine prices
int facebookFine = 150;
int instagramFine = 100;
int redditFine = 50;

// Variables for later use
int penaltyFee = 0;

// Circle through the websites
for (int i = 1; i <= n; i++)
{
  // Keep a website name in a variable, for later use
  string website = Console.ReadLine();

  switch (website)
  {
    // Check which website you visited and substract the fine from your salary
    case "Facebook":
    salary -= facebookFine;
    break;
    
    case "Instagram":
    salary -= instagramFine;
    break;
    
    case "Reddit":
    salary -= redditFine;
    break;
  }

  // Check if you lost your salary
  if (salary <= 0)
  {
    break;
  }
}

// Check whether you lost or kept your salary in order to print the correct message
  if (salary <= 0)
  {
    // Print the message
    Console.WriteLine("You have lost your salary.");
  }
  else if  (salary > 0)
  {
    // Print the message
    Console.WriteLine(salary);
  }