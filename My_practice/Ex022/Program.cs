// Найти расстояние между точками в пространстве 2D/3D

int X1 = 4;
int Y1 = 7;
int X2 = 5;
int Y2 = 1;
int Z1 = 18;
int Z2 = 16;

Console.WriteLine("Расстояние между точками в пространстве 2D " + Math.Sqrt((Math.Pow(X2-X1, 2)+Math.Pow(Y2-Y1, 2))));

Console.WriteLine("Расстояние между двумя точками в пространстве 3D " + Convert.ToInt32(Math.Sqrt((Math.Pow(X2-X1, 2)+Math.Pow(Y2-Y1, 2)+Math.Pow(Z2-Z1,2)))));
