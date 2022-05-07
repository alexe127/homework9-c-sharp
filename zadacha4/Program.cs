// Написать программу вычисления функции Аккермана

int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0) return Akkerman(a - 1, 1);
    else return Akkerman(a - 1, Akkerman(a, b - 1));
}

Console.Write("Введите число 1: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число 2: ");
int B = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Значение функции Аккермана = {Akkerman(A, B)}");