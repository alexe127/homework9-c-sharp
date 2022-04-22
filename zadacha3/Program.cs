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

int A = 3;
int B = 4;
int N = 5;
Fibo(A, B, N);
