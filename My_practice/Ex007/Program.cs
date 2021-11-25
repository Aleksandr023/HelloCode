//Показать числа от -N до N

Console.WriteLine("Введите любое число");
int N = int.Parse(Console.ReadLine());
if (N > 0)
{
    int X = -N;
    while (X <= N)
    {
        Console.Write(X);
        Console.Write(" ");
        X++;
    }
}
else
{
    int X = N;
    while (X <= N*-1)
    {
       Console.Write(X);
       Console.Write(" ");
       X++; 
    }
}