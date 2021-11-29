// Найти расстояние между точками в пространстве 2D/3D

double X1 = new Random().Next(-15, 16);
double Y1 = new Random().Next(-15, 16);
double X2 = new Random().Next(-15, 16);
double Y2 = new Random().Next(-15, 16);
double Z1 = new Random().Next(-15, 16);
double Z2 = new Random().Next(-15, 16);

Console.WriteLine("Координаты точки A " + (X1, Y1, Z1) + ", координаты точки B " + (X2, Y2, Z2));

Console.WriteLine("Расстояние между точками в пространстве 2D " + Math.Sqrt((Math.Pow(X2-X1, 2)+Math.Pow(Y2-Y1, 2))));

Console.WriteLine("Расстояние между двумя точками в пространстве 3D " + Math.Sqrt((Math.Pow(X2-X1, 2)+Math.Pow(Y2-Y1, 2)+Math.Pow(Z2-Z1,2))));
