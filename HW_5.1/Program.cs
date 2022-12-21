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

int CountEvenNumbers(int[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            count++;
        }
    } 
    return (count);
}
int degree = 3;
int[] a = CreateEmptyArray(5);
FillArray(a, 1 * Convert.ToInt32(Math.Pow(10, degree - 1)), 10 * Convert.ToInt32(Math.Pow(10, degree - 1)));
PrintArrayContent(a);
Console.WriteLine(CountEvenNumbers(a));