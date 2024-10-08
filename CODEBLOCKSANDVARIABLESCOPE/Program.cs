bool flag = true;
//declare your varıable outsıde ıf you want to get the value outsıde and ınsıde the code block however ıf they are dıfferent let the value be ınsıde the ıfstatemtent 
int value = 10;
if (flag)
{
    
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Inside the code block: {value}");
int myvalue = 5;
if (myvalue > 0)
{
    int value2 = 6;
    int newvalue = value2 + myvalue;
    Console.WriteLine(newvalue);
}
Console.WriteLine(myvalue);