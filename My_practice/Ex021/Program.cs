// Программа проверяет пятизначное число на палиндромом

Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());

if(number/10000 == number%10 && number/1000%10 == number%100/10)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}