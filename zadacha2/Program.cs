// Написать программу возведения числа А в целую степень B.

int Exponentiation(int a, int b)
{
    if (a < 0 || b < 0)
    {
        Console.WriteLine("введите числа >= 0");
        return -1;
    }
    if (b == 0) return 1;
    return a * Exponentiation(a, b - 1);
}
Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите целую степень b: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"{a} в степени {b} = {Exponentiation(a, b)}");
