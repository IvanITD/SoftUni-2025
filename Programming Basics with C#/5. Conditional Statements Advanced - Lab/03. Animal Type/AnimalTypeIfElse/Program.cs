string animalType = Console.ReadLine();

if (animalType == "dog")
{
    Console.WriteLine("mammal");
}
else if (animalType == "crocodile" || animalType == "tortoise" || animalType == "snake")
{
    Console.WriteLine("reptile");
}
else
{
    Console.WriteLine("unknown");
}