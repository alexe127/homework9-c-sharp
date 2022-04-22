// Написать программу вычисления функции Аккермана

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine();

int M = 3;
int N = 2;
Console.WriteLine($"Значение функции Аккермана = {Akkerman(M, N)}");
