internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<int, string> map = new SortedList<int, string>();

        // Adding elements to Dictionary
        map.Add(2, "Sachin");
        map.Add(1, "Rahul");
        map.Add(3, "Prakash");
        map.Add(5, "Rohit");
        map.Add(4, "Mahesh");

        // Traversing Dictionary
        foreach (var entry in map)         // entry is combination of key and value
        {
            Console.WriteLine("Key : " + entry.Key + " Value : " + entry.Value);
        }
    }
}