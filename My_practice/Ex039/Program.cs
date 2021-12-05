// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

int[] array = new int [10];
int index1 = 0;
int index2 = array.Length - 1;
FillArray(array);
PrintArray(array);
while (index1 < array.Length/2)
{
    Console.WriteLine($"{array[index1]} x {array[index2]} = {array[index1] * array[index2]}");
    index1++;
    index2--;
}
