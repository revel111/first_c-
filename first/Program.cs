public class Class
{
    public static double Func(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
            sum += array[i];

        return (double)sum / array.Length;
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Average: " + Func(numbers));
    }
}