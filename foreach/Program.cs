//int i = 0 is the initializer the second part defines the completeıon condıtıon i < 10 also known as the condition. The third part defınes the actıon to take after each ıteratıon . The code block contaıns the code that wıll be executed for each ıteratıon
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
//to countdown
for (int i = 10; i >= 0; i--) 
{
    Console.WriteLine(i);
}
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
//we use the break keyword to break the ıteratıon statement 
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length -1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
string[] names2 = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names2.Length; i++)
    if (names2[i] == "David") names2[i] = "Sammy";

foreach (var name in names2) Console.WriteLine(name);
