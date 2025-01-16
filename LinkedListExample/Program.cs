internal class Program
{
    private static void Main(string[] args)
    {

        // Create List

        LinkedList<int> list1 = new LinkedList<int>();              // Empty List -- Default Capacity -- 4

        // Adding Elements in List

        list1.AddLast(1);
        list1.AddLast(2);
        list1.AddLast(3);
        list1.AddFirst(4);       
        
        Console.WriteLine( " First Element Of List "  + list1.First());
        Console.WriteLine(" Last Element Of List " + list1.Last());
    }
}