//Показать числа от -N до N

Console.WriteLine("Введите любое число");
int N = int.Parse(Console.ReadLine());
int X = -N;
while (X <= N)
{
    Console.Write(X);
    Console.Write(" ");
    X++;
}