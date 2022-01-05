
int [] firstArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int [] finalArray = new int [firstArray.Length];
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] % 2 == 0)
    {
        finalArray[i] = firstArray[i];
        Console.Write(finalArray[i] + " ");
    }
    
}


