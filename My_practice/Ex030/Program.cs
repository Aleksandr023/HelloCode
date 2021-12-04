// Показать кубы чисел, заканчивающихся на четную цифру

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(10, 99);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] numbers = new int [15];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
int index = 0;
while (index < numbers.Length) 
{
    if(numbers[index]%2==0)
    {
       Console.Write($"{numbers[index]}^3 = {numbers[index]*numbers[index]*numbers[index]}; ");
    }
    index++;   
}
