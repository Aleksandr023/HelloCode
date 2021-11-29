// По двум заданным числам проверять является ли одно квадратом другого

int number1 = new Random().Next(1, 40); // 9 - можно задать число самостоятельно
int number2 = new Random().Next(1, 40);  // 9 - можно задать число самостоятельно
Console.WriteLine(number1);
Console.WriteLine(number2);

if(Math.Sqrt(number1) == number2)
{
    Console.WriteLine(number1 + " является квадратом " + number2);
 
}
if(Math.Sqrt(number2) == number1)
{
    Console.WriteLine(number2 + " является квадратом " + number1);
 
}
if(Math.Sqrt(number1) != number2 && Math.Sqrt(number2) != number1)
{
    Console.WriteLine("Условия не выполняются");
}