//Welcome message
Console.WriteLine("Represent");
Console.WriteLine("---------");
Console.WriteLine();

//string to int using Parse
string priceTag = "442";
int price = int.Parse(priceTag);
Console.WriteLine($"Price in string       : {priceTag}");
Console.WriteLine($"Price in integer      : {price}");
Console.WriteLine();

// int to double using Casting
int magicNumber = 231;
double magicDouble = (double)magicNumber;
Console.WriteLine($"Magic in integer      : {magicNumber}");
Console.WriteLine($"Magic in double       : {magicDouble}");
Console.WriteLine();

// double to decimal using Casting
double doubleNumber = 45.21;
decimal decimalNumber = (decimal)doubleNumber;
Console.WriteLine($"Number in double      : {doubleNumber}");
Console.WriteLine($"Number in decimal     : {decimalNumber}");
Console.WriteLine();

//string to int using TryParse
Console.Write("Give me a whole number: ");
bool isWholeNumber = int.TryParse(Console.ReadLine(), out int givenNumber);
Console.WriteLine($"It is {isWholeNumber} that you gave me a whole number.");
Console.WriteLine($"That's why its converted value in integer is {givenNumber}");
Console.ReadLine();