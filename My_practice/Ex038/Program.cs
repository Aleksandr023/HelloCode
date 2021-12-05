// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] composition)
{
    int index = 0;
    int size = composition.Length;
    while (index < size)
    {
        composition[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] array)

{
    int position = 0;
    int length = array.Length;
    while (position < length)
    {
        Console.Write($"{array[position]} ");
        position++;
    }
}

int[] summ = new int[15];
int summx = 0;
int index = 0;
FillArray(summ);
PrintArray(summ);

while (index < summ.Length)
{
    
    if (index % 2 != 0)
    {
        summx = summx + summ[index];
    }
    index++;
}
Console.WriteLine();
Console.WriteLine(summx);