// Найти сумму цифр числа

int sum =0;
void sumNum(int n )
{
    if (n == 0) return;        
    sum = sum + n % 10;
    sumNum( n / 10);
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");
sumNum(num);
Console.WriteLine($"Сумма цифр в числе = {sum} ");