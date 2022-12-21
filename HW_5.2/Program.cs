int[] CreateEmptyArray(int l)
{
    int[] array = new int[l];
    return (array);
}

int[] FillArray(int[] array, int min, int max)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return (array);
}

void PrintArrayContent(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int SummOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return (sum);
}

int[] a = CreateEmptyArray(5);
FillArray(a, -100, 101);
PrintArrayContent(a);
Console.WriteLine(SummOddElements(a));