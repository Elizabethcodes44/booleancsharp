int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"my decimal: {myDecimal}");

decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}");

int myInt2 = (int)myDecimal;
Console.WriteLine($"int: {myInt2}");

decimal myDecimal3 = 1.23456789m;
float myFloat = (float)myDecimal3;

Console.WriteLine($"Decimal: {myDecimal3}");
Console.WriteLine($"Float  : {myFloat}");

int third = 5;
int fourth = 6;
string message = third.ToString() + fourth.ToString();
Console.WriteLine(message);

string fifth = "5";
string sixth = "7";
int sum = int.Parse(fifth) + int.Parse(sixth);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result1 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result1);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);
//use convert.ınt32 to round up a decimal use parse to convert string to ınteger
int value3 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value3);