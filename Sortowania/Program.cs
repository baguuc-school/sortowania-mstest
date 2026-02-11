using Sortowania.Interface;
using Sortowania.Strategies;

public static class Program
{
    public static void Main(string[] args)
    {
        InsertSortStrategy<int> strategy = new InsertSortStrategy<int>();
        int[] result = strategy.Sort(new int[] { 5, 3, 3, 1, 2, 4 });

        Console.WriteLine(string.Join(", ", result));
    }
}