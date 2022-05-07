// Найти сумму цифр числа

int SumNumber(int n )
{
    if (n == 0) return n; 
      return n % 10 +  SumNumber(n / 10 );     
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine(SumNumber(num));