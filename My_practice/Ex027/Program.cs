// Определить количество цифр в числе
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int digits = 0; // кол-во цифр
while (number > 0)
{
  digits++;
  number = number/10;
}
Console.WriteLine($"В числе {digits} цифр");