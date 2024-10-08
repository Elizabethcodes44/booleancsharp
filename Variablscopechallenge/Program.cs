int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;
foreach (int number in numbers)
   {
    if (number == 42)
    Console.WriteLine("set contains 42");
    total += number;
    
   }

  

Console.WriteLine($"Total: {total}");
