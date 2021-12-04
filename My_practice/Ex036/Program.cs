// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
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
    Console.WriteLine();
}

void EvenOdd(int[] array) // метод нахождения количества четных и нечетных чисел
{
    int index = 0;
    int length = array.Length;
    int even = 0;
    int odd = 0;
    while(index < length)
    {
        if(array[index]%2==0)
        {
            even++;
        }
        else
        {
            odd++;
        }
        index++;
    }
    Console.WriteLine($"Четных чисел: {even}");
    Console.WriteLine($"Нечетных чисел: {odd}");
}

int[] newarray = new int [20];

FillArray(newarray);
PrintArray(newarray);
EvenOdd(newarray);
