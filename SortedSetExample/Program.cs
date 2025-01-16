internal class Program
{
    private static void Main(string[] args)
    {
        SortedSet<int> set = new SortedSet<int>() { 10, 5, 23, 56, 34, 66, 34 , 5};
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }
}