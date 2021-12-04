//Написать программу замену элементов массива на противоположные

void FillArray(int[] name)
{
    int length = name.Length;
    int index = 0;
    while (index < length)
    {
        name[index] = new Random().Next(-10, 10);
        index++;
    }
}

void PrintArray(int[] gogo)
{
    int position = 0;
    int count = gogo.Length;
    while (position < count)
    { 
        Console.Write($"{gogo[position]} ");
        position++;
    }
}

void MinPlusChange(int[] array1)
{
    int count = 0;
    int length = array1.Length;
    while (count < length)
    {
        array1[count] = array1[count]*(-1);
        count++;
    }
}


int[] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
MinPlusChange(array);
PrintArray(array);