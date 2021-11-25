// Дано число. Проверить кратно ли оно 7 и 23

int N = new Random().Next(-1000, 1001);
if (N%7==0)
{
    if (N%23==0)
    {
        Console.Write(N);
        Console.Write(" кратно 7 и 23");
    }
    else
    {
        Console.Write(N);
        Console.Write(" не кратно 7 и 23");
    }
}
else
{
    Console.Write(N);
    Console.Write(" не кратно 7 и 23");
}
