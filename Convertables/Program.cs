// Welcome message
Console.WriteLine("Convertables");
Console.WriteLine("------------");
Console.WriteLine();

// string to int using Parse
string textValue = "123";
int numberValue = int.Parse(textValue);
Console.WriteLine($"Text Value                  : {textValue}");
Console.WriteLine($"Number Value                : {numberValue}");
Console.WriteLine();

// int to double using casting
int intValue = 456;
double doubleValue = (int)intValue;
Console.WriteLine($"Integer Value               : {intValue}");
Console.WriteLine($"Double Value                : {doubleValue}");
Console.WriteLine();

// double to decimal using casting
double anotherDouble = 67.89;
decimal decimalValue = (decimal)anotherDouble;
Console.WriteLine($"Another Double Value        : {anotherDouble}");
Console.WriteLine($"Decimal Value               : {decimalValue}");
Console.WriteLine();

// string to int using TryParse
Console.Write("Given me some real number   : ");
int.TryParse(Console.ReadLine(), out int realNumber);
Console.WriteLine($"It Is Converted Into        : {realNumber}");
Console.WriteLine();

Console.Write("Give me now worded number   : ");
int.TryParse(Console.ReadLine(), out int worderedNumber);
Console.WriteLine($"Now, It Is Converted To     : {worderedNumber}");
Console.ReadLine();