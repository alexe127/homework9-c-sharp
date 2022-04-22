// Написать программу возведения числа А в целую степень B.

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Введите число: ");
// int b = int.Parse(Console.ReadLine() ?? "");

Random rnd = new Random();
int a = rnd.Next(1,10);
int b = rnd.Next(1,5);
int result = 1;

void Recurs(int n)
{
    if (n == 0) return;
    result *= a;
    Recurs(n - 1);
}

Recurs(b);
Console.WriteLine($"{a}  в степени {b} =  {result}");
