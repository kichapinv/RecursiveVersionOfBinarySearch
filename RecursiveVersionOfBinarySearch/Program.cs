internal class Program
{
    private static void Main(string[] args)
    {
        long[] firstExampleArray = new long[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        long[] secondExampleArray = new long[] { 1, 2, 3, 4, 6, 10, 13, 14, 15 };
        long[] thirdExampleArray = new long[] { 1, 2, 3, 4, 6, 10, 20, 30, 33, 35, 40 };
        long firstExampleNumber = 2;
        long secondExampleNumber = 13;
        long thirdExampleNumber = 4;

        Console.WriteLine(FindLeftBorder(firstExampleArray, firstExampleNumber));
        Console.WriteLine(FindLeftBorder(secondExampleArray, secondExampleNumber));
        Console.WriteLine(FindLeftBorder(thirdExampleArray, thirdExampleNumber));
    }

    public static int FindLeftBorder(long[] arr, long value)
    {
        return BinSearchLeftBorder(arr, value, -1, arr.Length);
    }

    public static int BinSearchLeftBorder(long[] array, long value, int left, int right)
    {
        if (array.Length == 0) return -1;
        if (array[right - 1] < value) return right - 1;
        if (array[left + 1] >= value) return left;
        var m = (left + right) / 2;
        if (array[m] < value)
            return BinSearchLeftBorder(array, value, m, right);
        return BinSearchLeftBorder(array, value, left, m);
    }
}