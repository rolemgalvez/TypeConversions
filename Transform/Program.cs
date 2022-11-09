// Welcome message
Console.WriteLine("Transform");
Console.WriteLine("---------");
Console.WriteLine();

//string to int using Parse
string digitText = "234";
int digitNumber = int.Parse(digitText);
Console.WriteLine($"Digit Text                                : {digitText}");
Console.WriteLine($"Digit Number                              : {digitNumber}");
Console.WriteLine();

//int to double using Casting
int numberInt = 9292;
double numberDouble = (double)numberInt;
Console.WriteLine($"Number Int                                : {numberInt}");
Console.WriteLine($"Number Double                             : {numberDouble}");
Console.WriteLine();

//double to decimal using Casting
double priceDouble = 34.632;
decimal priceDecimal = (decimal)priceDouble;
Console.WriteLine($"Price Double                              : {priceDouble}");
Console.WriteLine($"Price Decimal                             : {priceDecimal}");
Console.WriteLine();

//string to int using TryParse
Console.Write("Give me a real whole number               : ");
bool isNumber = int.TryParse(Console.ReadLine(), out int giveNumber);
Console.WriteLine($"Your given input is real whole number? That's {isNumber}!");
Console.WriteLine($"Now, its transformed value is {giveNumber}");
Console.WriteLine();

Console.Write("Let's do this again. Give me worded number: ");
bool isWordedNumber = !int.TryParse(Console.ReadLine(), out int wordedNumber);
Console.WriteLine($"You gave worded number? That's {isWordedNumber}!");
Console.WriteLine($"So its tranformed value is {wordedNumber}");
Console.ReadLine();