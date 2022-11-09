//Welcome message
Console.WriteLine("Flip");
Console.WriteLine("----");
Console.WriteLine();

//string to int using Parse
string valueString = "0923823";
int valueInt = int.Parse(valueString);
Console.WriteLine($"Value String                            : {valueString}");
Console.WriteLine($"Value Int                               : {valueInt}");
Console.WriteLine();

//int to double using Casting
int priceInt = 1234567890;
double priceDouble = (double)priceInt;

//double to decimal using Casting
double amountDouble = 210392.01293239;
decimal amountDecimal = (decimal)amountDouble;
Console.WriteLine($"Amount Double                           : {amountDouble}");
Console.WriteLine($"Amount Decimal                          : {amountDecimal}");
Console.WriteLine();

//string to double using TryParse
Console.Write("Enter a decimal number                  : ");
bool isDouble = double.TryParse(Console.ReadLine(), out double givenDouble);
Console.WriteLine($"You gave a {isDouble} decimal number.");
Console.WriteLine($"Its flip double type value is {givenDouble}");
Console.WriteLine();

//string to decimal using TryParse
Console.Write($"Let's try again. Enter a decimal number: ");
bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal givenDecimal);
Console.WriteLine($"You gave a {isDecimal} decimal number.");
Console.WriteLine($"Its flip decimal type value is {givenDecimal}");
Console.ReadLine();