// task 2
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m > n)
    Console.Write($"max = {m}");
else
    Console.Write($"max = {n}");
 
 
// task4
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
    if (a > c)
   
        Console.Write($"max = {a}");
   
    else
   
        Console.Write($"max = {c}");
else if (b > c)
    Console.Write($"max = {b}");
else
    Console.Write($"max = {c}");
 
// task6
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
    Console.Write("Четное");
else
    Console.Write("Нечетное");
 
//task8
Console.WriteLine("Введите число: ");
int f = Convert.ToInt32(Console.ReadLine());
for(int ff = 1; ff<=f; ff++)
    if(ff % 2 == 0)
      Console.Write($" {ff} ");  
    else
        Console.Write("");
