// Определить, присутствует ли в заданном массиве, некоторое число
void FillArray(int[] array)
{
    int index = 0;
    int length = array.Length;
    while (index < length)
    {
        array[index] = new Random().Next(1, 99);
        index++;
    }
}

void PrintArray(int[] numbers)
{
    int count = 0;
    int length = numbers.Length;
    while (count < length)
    {
        Console.Write($"{numbers[count]} ");
        count++;
    }
    Console.WriteLine();
}

void FindNumber(int[] array)
{
    int length = array.Length;
    Console.Write("Введите искомое число: ");
    int number = int.Parse(Console.ReadLine());
    for (int index = 0; index < length; index++)
    {
        if (number == array[index])
        {
            Console.WriteLine($"Число {number} присутствует в массиве под индексом {index}");
            break;
        }
    }        
}    

int[] testarray = new int [15];

FillArray(testarray);
PrintArray(testarray);
FindNumber(testarray);




