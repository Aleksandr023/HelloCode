// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int N = new Random().Next(1, 100);
Console.WriteLine(N);
Console.WriteLine("Введите своё число");
int A = int.Parse(Console.ReadLine());

if(A%N==0)
{
    Console.WriteLine("OK");
}
else 
{
    Console.WriteLine(A%N);  // % - покажет нам остаток от деления
}