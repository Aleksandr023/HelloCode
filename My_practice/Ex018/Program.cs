// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool X = true;
bool Y = true;
bool Z = !(X && Y) == !X & !Y;
Console.WriteLine(Z);