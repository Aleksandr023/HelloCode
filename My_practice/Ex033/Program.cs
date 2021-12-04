// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray(int[] newArray)
{
    int count = newArray.Length;
    int position = 0;
    while (position < newArray.Length)
    {
        Console.Write($"{newArray[position]} ");
        position++;
    }
}

int[] numbers = new int[12];

FillArray(numbers);
PrintArray(numbers);

int index = 0;
int resultplus = 0;
int resultminus = 0;

while (index<numbers.Length)
{
    if (numbers[index] > 0)
    {
        resultplus = resultplus + numbers[index];
    }
    else
    {
        resultminus = resultminus + numbers[index];
    }
    index++;
}
//else
//{
//    resultminus = resultminus + numbers[index];
//}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива = {resultplus}");
Console.WriteLine($"Сумма отрицательных элементов массива = {resultminus}");