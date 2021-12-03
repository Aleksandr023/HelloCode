// Подсчитать сумму цифр в числе

int number = int.Parse(Console.ReadLine());
int summ = 0;
while (number > 0)
{
    summ = summ + number%10;
    number = number/10;
}
Console.WriteLine(summ);
