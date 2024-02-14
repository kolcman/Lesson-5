void ZeroEvenElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array[i] = 0;
        }
    }
}

void printArray(int[] array)
{
    foreach (int e in array)
    {
        System.Console.Write($"{e} ");
    }
}


int[] array = { 5, 3, 5, 7, 82, 2, 6 };
ZeroEvenElements(array);
printArray(array);
