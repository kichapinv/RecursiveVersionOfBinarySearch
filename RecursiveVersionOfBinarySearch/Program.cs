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
            var array = GenerateRandomArray(int.Parse(lengthOfArray));
            WriteAnInputArray(array);
            Console.Write("Now insert a number your want to work with: ");
            var number = Console.ReadLine();
            Console.Write("And L for left border or R for riht border want to find: ");
            var border = Console.ReadLine();
            var result = FindBorder(array, int.Parse(number), char.Parse(border));
            if (result == -1)
            {
                Console.WriteLine("Something went wrong! Lets try again!");   
            }
            else Console.WriteLine(result);
        };
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
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write("{0} - {1} ", i, inputArray[i]);
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    public static int FindBorder(int[] arr, int value, char border)
    {

        if (border == 'R' || border == 'r') return BinSearchRightBorder(arr, value, -1, arr.Length);
        else if (border == 'L' || border == 'l') return BinSearchLeftBorder(arr, value, -1, arr.Length);
        else return -1;

    }

    public static int BinSearchRightBorder(int[] array, long value, int left, int right)
    {
        if (array.Length == 0) return -1;
        if (array[right - 1] <= value) return right + 1;
        if (array[left + 1] > value) return left;
        var m = (left + right) / 2;
        if (array[m] < value)
            return BinSearchRightBorder(array, value, m, right);
        return BinSearchRightBorder(array, value, left, m);
    }

    public static int BinSearchLeftBorder(int[] array, long value, int left, int right)
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