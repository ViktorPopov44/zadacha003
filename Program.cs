int n = Convert.ToInt32(Console.ReadLine());

int[] TableSquares(int s)
{
    int[] array = new int[s];

    for (int i = 1; i <= n; i++)
    {
        array[i - 1] = i * i;
    }
    return array;
}
int[] result = TableSquares(n);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
