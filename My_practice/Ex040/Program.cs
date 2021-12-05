// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 10) + new Random().NextDouble();
        index++;
    }
}

void PrintArray(double[] newArray)
{
    int count = newArray.Length;
    int position = 0;
    while (position < newArray.Length)
    {
        Console.Write($"{Math.Round(newArray[position], 2)} "); // Math.Round(число, количество знаков после запятой) округляет до нужного количества знаков
        position++;
    }
    Console.WriteLine();
}

double[] array = new double[15];
FillArray(array);
PrintArray(array);
double min = array[0];
double max = array[1];
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < min) min = array[index];
    if (array[index] > max) max = array[index];
}

Console.WriteLine($"{Math.Round(max, 2)} - {Math.Round(min, 2)} = {Math.Round(max - min, 2)}");