public class Class
{
    public static double Func(int[] array)
    {
        int sumxxxx = 0;

        for (int i = 0; i < array.Length; i++)
            sumxxxx += array[i];

        return (double)sumxxxx / array.Length;
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