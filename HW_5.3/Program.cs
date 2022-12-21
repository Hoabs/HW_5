double[] CreateEmptyArray(int l)
{
    double[] array = new double[l];
    return (array);
}

double[] FillArray(double[] array, int min, int max)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*(max-min)+min, 2);
    }
    return (array);
}

void PrintArrayContent(double[] array)
{
    Console.WriteLine($"[{string.Join("; ", array)}]");
}

double FindMinMaxSum(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }

    return (Math.Round(min+max, 2));
}

double[] a = CreateEmptyArray(5);
FillArray(a, -100, 101);
PrintArrayContent(a);
Console.WriteLine(FindMinMaxSum(a));