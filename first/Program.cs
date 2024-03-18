public class Class
{
    public static double Func(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
            sum += array[i];

        return (double)sum / array.Length;
    }

    public static int FuncMax(int[] array)
    {
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];

        return max;
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 100, 4, 5 };
        Console.WriteLine("Average: " + Func(numbers));

        Console.WriteLine(FuncMax(numbers));
    }
}