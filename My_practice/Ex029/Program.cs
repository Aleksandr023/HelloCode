// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
double result = 1;
for (int i = 2; i <= N; i++)
{
    result = result * i;
}
Console.WriteLine(result);
