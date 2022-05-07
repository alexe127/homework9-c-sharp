//Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем

void Fibo(int a, int b, int n)
{
    int temp = 0;
    if (n == 0) return;
    else
    {
        Console.Write(a + " ");
        temp = a + b;
        a = b;
        b = temp;
        n--;
        Fibo(a, b, n);
    }
}
Console.Write("Введите число 1: ");
int firstElement = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число 2: ");
int secondElement = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество элементов: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Fibo(firstElement, secondElement, N);