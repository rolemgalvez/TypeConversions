//Welcome message
Console.WriteLine("Exchange");
Console.WriteLine("--------");
Console.WriteLine();

//string to int using Parse
string valueString = "20912";
int valueInt = int.Parse(valueString);
Console.WriteLine($"Value String                                    : {valueString}");
Console.WriteLine($"Value Int                                       : {valueInt}");
Console.WriteLine();

//int to double using Casting
int countInt = 293;
double countDouble = (double)countInt;
Console.WriteLine($"Count Int                                       : {countInt}");
Console.WriteLine($"Count Double                                    : {countDouble}");
Console.WriteLine();

//double to decimal using Casting
double amountDouble = 123.4214566;
decimal amountDecimal = (decimal)amountDouble;
Console.WriteLine($"Amount Double                                   : {amountDouble}");
Console.WriteLine($"Amount Decimal                                  : {amountDecimal}");
Console.WriteLine();

//string to double using TryParse
Console.Write($"Give me real decimal number                     : ");
bool isDouble = double.TryParse(Console.ReadLine(), out double givenNumber);
Console.WriteLine($"You gave me {isDouble} decimal number.");
Console.WriteLine($"Its exhanged double type value is {givenNumber}");
Console.WriteLine();

//string to decimal using TryParse
Console.Write($"Let's do it again, give another decimal number  : ");
bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal givenDecimal);
Console.WriteLine($"You gave me {isDecimal} decimal number.");
Console.WriteLine($"Its exchanged decimal type value is {givenDecimal}");
Console.ReadLine();