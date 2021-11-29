// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int N = 28;//new Random().Next(1, 100);
Console.WriteLine(N);
Console.WriteLine("Введите своё число");
int A = 5;//int.Parse(Console.ReadLine());

if(N%A==0)
{
    Console.WriteLine("OK");
}
else 
{
    Console.WriteLine(N%A);  // % - покажет нам остаток от деления
}