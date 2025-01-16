internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>();

        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(4);
        set.Add(3);


        foreach (var item in set)
        {
            Console.WriteLine(item);
        }

        // Union Operation
        HashSet<int> set1 = new HashSet<int>() { 2, 4, 5, 6 };

        // set.UnionWith(set1);
        // set.IntersectWith(set1);

        set.ExceptWith(set1);           // will keep all elements of set which are not available in set1 

        // Console.WriteLine(" Union Output : ");
        // Console.WriteLine(" Intersection Output : ");

        Console.WriteLine(" Difference Output : ");
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
        


    }
}   