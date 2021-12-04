// Задать массив из 8 элементов и вывести их на экран

void FillArray(int[] array)
{
    int length= array.Length;
    int index = 0;
    while (index<length)
    {
        array[index] = new Random().Next(0, 99);
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

int[] numbers = new int [8];

FillArray(numbers);
PrintArray(numbers);
