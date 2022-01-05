// Выяснить являются ли три числа сторонами треугольника 

int sideA = int.Parse(Console.ReadLine());
int sideB = int.Parse(Console.ReadLine());
int sideC = int.Parse(Console.ReadLine());

if ((sideB+sideC<sideA)||(sideA+sideC<sideB)||(sideA+sideB<sideC)) Console.WriteLine("Не треугольник");
else 
{
    Console.WriteLine("Треугольник");
}
