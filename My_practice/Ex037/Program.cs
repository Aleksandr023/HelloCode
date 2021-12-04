// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 1000);
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

void Numbers(int[] array) // метод нахождения чисел в определенном промежутке
{
    int index = 0;
    int length = array.Length;
    int count = 0;
    while(index < length)
    {
        if(array[index]<100 && array[index]>9)
        {
            count++;
        }
        index++;
    }
    Console.WriteLine($"Количество элементов из отрезка [10,99]: {count}");
}

int[] array = new int[123];

FillArray(array);
PrintArray(array);
Numbers(array);
