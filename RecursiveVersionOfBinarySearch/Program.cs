internal class Program
{
    public static Random random = new Random();

    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hello! Lets check left border or right border of binary search! " +
                "If you want to exit press E or any other key to continue!");
            char key = Console.ReadKey(true).KeyChar;
            if (key == 'e' || key == 'E') return;
            Console.WriteLine("We will generate random array with items not larger 99, sort it and find a border.");
            Console.Write("Insert the length of array: ");
            var lengthOfArray = Console.ReadLine();
            WriteAnInputArray(GenerateRandomArray(int.Parse(lengthOfArray)));
        }    
        
        

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

    public static int[] GenerateRandomArray(int lengthOfArray)
    {
        int[] array = new int[lengthOfArray];
        for (int i = 0; i < lengthOfArray; i++)
        {
            array[i] = random.Next(100);
        }
        Array.Sort(array);
        return array;
    }

    public static void WriteAnInputArray(int[] inputArray)
    {
        foreach (var item in inputArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
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