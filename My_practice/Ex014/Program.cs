// Найти третью цифру числа или сообщить, что её нет

int N = new Random().Next(-30000, 30000);
Console.WriteLine(N);
if (N >= -99 && N <= 99)
{
    Console.WriteLine("Третья цифра отсутствует");
}
else
{
    if (N < -99)
    {
        Console.WriteLine(N.ToString()[3]); // ToString() - преобразовывает объект в строку, + [1] - выводит элемент с индексом 1
    }
    else
    {
        Console.WriteLine(N.ToString()[2]);
    }
    
}

