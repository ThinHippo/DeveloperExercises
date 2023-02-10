// Вывести все числа от N до -N
Console.WriteLine("Hello, World!");
public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, index;
        
        Console.WriteLine("Введите целое число");
        n = (int) inputValue();
        for (index = -n; index <= n; index++)
        {
            Console.WriteLine(index);
        }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
