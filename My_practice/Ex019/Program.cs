// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int coordinateX = new Random().Next(-10, 11);
int coordinateY = new Random().Next(-10, 11);
Console.WriteLine(coordinateX);
Console.WriteLine(coordinateY);

if(coordinateX>0 && coordinateY>0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if(coordinateX>0 && coordinateY<0)
{
    Console.WriteLine("Точка находится в четвёртой четверти");
}
else if (coordinateX<0 && coordinateY<0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else
{
    Console.WriteLine("Точка находится во второй четверти");
}