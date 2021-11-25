// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

int[] DaysOfWeek = {1,2,3,4,5,6,7};
Console.WriteLine("Введите номер дня недели");
int NumberOfDay = int.Parse(Console.ReadLine());
if (NumberOfDay>=DaysOfWeek[0] && NumberOfDay <= DaysOfWeek[4])
{
    Console.WriteLine("Это будний день, работаем(((");
}
if (NumberOfDay>=DaysOfWeek[5] && NumberOfDay <= DaysOfWeek[6])
{
    Console.WriteLine("Это выходной! УРА!");
}